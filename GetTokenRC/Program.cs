namespace GetTokenRC
{
    using Dapper;
    using GetTokenRC.RCServiceReference;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Xml.Serialization;

    class Program
    {
        public static RCServiceClient serviceClient = new RCServiceClient();
        public static Logger logger = new Logger();
        public static StringBuilder logMsg = new StringBuilder();
         static void Main(string[] args)
        {
            
            string filePath = ConfigurationManager.AppSettings["filePath"].ToString();

            //string filePath = @"Clientes/clientes.txt";
            try
            {  
                    string line;
                    StreamReader file = new StreamReader(filePath);
                    var lastUserRC = "";
                    var token = "";
                while ((line = file.ReadLine()) != null)
                {
                    string[] client = line.Split(';');
                    if (client.Length == 5)
                    {
                        var userVia = client[0];
                        var customerID = client[1];
                        var customerName = client[2];
                        var userRC = client[3];
                        var passwordRC = client[4];
                        if (userRC != lastUserRC)
                        {
                            lastUserRC = userRC;
                            UserTokenResult tokenResult2 = serviceClient.GetUserToken(userRC, passwordRC);
                            if (tokenResult2.exception != null)
                            {
                                logMsg.AppendLine("Error al intentar obtener token: usuario: " + userVia);
                                Console.WriteLine(tokenResult2.exception["message"]);
                                logger.Add(tokenResult2.exception["message"]);
                                lastUserRC = "";
                                continue;
                            }else
                            token = tokenResult2.token;
                        }
                            sendRC(userVia, customerID, customerName, token);
                    }
                }
                    file.Close();
               
            }
            catch (Exception ex)
            {
                logger.Add(ex.Message);
            }
            logger.Add(logMsg.ToString());

         }

        public static void sendRC(string userVia, string customerID, string customerName, string token)
        {
            logMsg.AppendLine("------------------------Request---------------------");
            Console.WriteLine("Buscando dispositivos de " + userVia);
            logMsg.AppendLine("Buscando dispositivos de " + userVia);
            List<Device> devices = GetDevices(userVia);
            Console.WriteLine("Dispositivos encontrados: " + devices.Count());
            logMsg.AppendLine("------------------------- Dispositivos encontrados: " + devices.Count() + "-------------------------");
            List<Event> events = new List<Event>();
            try
            {
                if (devices.Count() > 0)
                {
                    foreach (var item in devices)
                    {
                        try
                        {
                            Event evento = new Event
                            {
                                code = item.code,
                                date = item.eventDate,
                                latitude = item.latitude.ToString(),
                                longitude = item.longitude.ToString(),
                                asset = item.asset,
                                direction = GetAddress(item.latitude, item.longitude),
                                speed = Math.Round(item.speed, MidpointRounding.ToEven).ToString(),
                                customer = new Customer
                                {
                                    id = customerID,
                                    name = customerName
                                },
                                odometer = Math.Round(item.odometer / 1000, MidpointRounding.ToEven).ToString(),
                                ignition = item.inIgnition.ToUpper(),
                                course = GetCardinalPoints(item.course)
                            };
                            events.Add(evento);
                        }
                        catch (Exception ex)
                        {
                            logMsg.AppendLine( item.nombre + "Unidad sin datos");
                        }
                    }
                    
                    logMsg.AppendLine(token);
                    using (var stringwriter = new StringWriter())
                    {
                        var serializer = new XmlSerializer(events.GetType());
                        serializer.Serialize(stringwriter, events);
                        logMsg.AppendLine("----------------------- XMLRequest ----------------------");
                        logMsg.AppendLine(stringwriter.ToString());
                    }

                    var appointsResult = serviceClient.GPSAssetTracking(token, events.ToArray());
                    logMsg.AppendLine("----------------------- Response ----------------------");
                    if (appointsResult.Count() != 0)
                    {
                        if (appointsResult[0].exception != null)
                        {
                            Console.WriteLine(appointsResult[0].exception["message"]);
                            logMsg.AppendLine(appointsResult[0].exception["message"]);
                            logMsg.AppendLine("idJob: " + appointsResult[0].idJob.ToString());
                        }
                        else
                        {
                            logMsg.AppendLine("idJob: " + appointsResult[0].idJob.ToString());
                        }
                    }
                    else
                    {
                        logMsg.AppendLine("Sin respuesta");
                    }
                }
                else
                {
                    logMsg.AppendLine("Sin dispositivos");
                }
            }
            catch (Exception ex)
            {

                logMsg.AppendLine(ex.Message);
            }

        }
        public static string GetAddress(double latitud, double longitud)
        {
            var result = "";
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.GetAsync("http://reverse.geocoder.api.here.com/6.2/reversegeocode.json?app_id=sIATJa6F5fmasKeBt1wJ&app_code=0ZbkLY5vZ54dl6y_5PP9Pg&prox=" + latitud + "," + longitud + ",200&mode=retrieveAddresses&gen=8").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var a = response.Content.ReadAsStringAsync().Result;
                        dynamic b = JsonConvert.DeserializeObject(a);
                        result = b["Response"]["View"][0]["Result"][0]["Location"]["Address"]["Label"];
                    }
                }
            }
            catch (Exception )
            {
                result = "Sin datos";
            }
            
            
            return result;
        }
        public static string GetCardinalPoints(double grados)
        {

            var result = "";
            if((grados >= 337.5 && grados <= 360)||(grados >= 0 && grados <= 22.4) )
                result = "Norte";
            else if(grados >= 22.5 && grados <= 67.4)
                result = "Noreste";
            else if (grados >= 67.5 && grados <= 112.4)
                result = "Este";
            else if (grados >= 112.5 && grados <= 157.4)
                result = "Sureste";
            else if (grados >= 157.5 && grados <= 202.4)
                result = "Sur";
            else if (grados >= 202.5 && grados <= 247.4)
                result = "Suroeste";
            else if (grados >= 247.5 && grados <= 292.4)
                result = "Oeste";
            else if (grados >= 292.5 && grados <= 237.4)
                result = "Noroeste";

                return result;
        }
        public static List<Device> GetDevices(string userVia)
        {
            DbConnectionFactory connectionFactory = new DbConnectionFactory();
            List<Device> result = new List<Device>();
            using (var cnn = connectionFactory.Create())
            {
                cnn.Open();
                result = cnn.Query<Device>(new Queries.GetDevices().TransformText(),new { userVia }).ToList();
            }
            return result;
        }
    }
}
