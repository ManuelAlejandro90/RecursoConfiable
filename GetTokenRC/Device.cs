namespace GetTokenRC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Device
    {
        public string nombre { get; set; }
        public string asset { get; set; }
        public string code { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string inIgnition { get; set; }
        public double speed { get; set; }
        public DateTime eventDate { get; set; }
        public double odometer { get; set; }
        public double course { get; set; }
        public string direction { get; set; }

    }
}