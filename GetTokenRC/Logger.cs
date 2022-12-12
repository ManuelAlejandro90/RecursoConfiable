namespace GetTokenRC
{
    using System;
    using System.Configuration;
    using System.IO;

    public class Logger
    {
        private string Path = ConfigurationManager.AppSettings["logPath"].ToString();
        //private string Path = @"Log/";
        public void Add(string sLog)
        {
            try
            {
                CreateDirectory();
                string nameFile = GetNameFile();
                string str = "" + DateTime.Now + " - " + sLog + Environment.NewLine;
                StreamWriter streamWriter = new StreamWriter(Path + "/" + nameFile, true);
                streamWriter.Write(str);
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetNameFile() => "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

        private void CreateDirectory()
        {
            try
            {
                if (Directory.Exists(this.Path))
                    return;
                Directory.CreateDirectory(this.Path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
