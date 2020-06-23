using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Booking
    {
        public int ID { get; set; }
        public string Kommentar { get; set; }
        public string Dato { get; set; }
        public string Klokkeslæt { get; set; }
        public int Ejertlf { get; set; }
        public int DyrlægeID { get; set; } 

        public string BehandlingsType { get; set; }



        public Booking(string kommentar, string dato, string klokkeslæt, int ejertlf, int dyrlægeID, string behandlingsType)
        {
            Kommentar = kommentar;
            Dato = dato;
            Klokkeslæt = klokkeslæt;
            Ejertlf = ejertlf;
            DyrlægeID = dyrlægeID;
            BehandlingsType = behandlingsType;
        }

        public Booking()
        {
        }

        
    }
}
