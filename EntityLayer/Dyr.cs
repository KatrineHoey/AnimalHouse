using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Dyr
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string DyreType { get; set; }
        public int Fødselsår { get; set; }
        public string Køn { get; set; }
        public double Vægt { get; set; }
        public string Kommentar { get; set; }
        public int Ejer { get; set; }
        public int Dyrlæge { get; set; }

        public Dyr(string navn, string dyretype, int fødselsår, string køn, double vægt, string kommentar, int ejer, int dyrlæge)
        {
            Navn = navn;
            DyreType = dyretype;
            Fødselsår = fødselsår;
            Køn = køn;
            Vægt = vægt;
            Kommentar = kommentar;
            Ejer = ejer;
            Dyrlæge = dyrlæge;
            
        }
        public Dyr ()
        {

        }
    }
}
