using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Salg
    {
        public int ID { get; set; }
        public string Beskrivelse { get; set; }
        public decimal Pris { get; set; }
        public int Antal { get; set; }
        public int Type { get; set; }
        public decimal IndkøbsPris { get; set; }
        public decimal IndkøbsPrisIalt { get; set; }


        public Salg(int id, string beskrivelse, decimal pris, int antal, int type, int indkøbspris, int indkøbsprisialt)
        {
            ID = id;
            Beskrivelse = beskrivelse;
            Pris = pris;
            Antal = antal;
            Type = type;
            IndkøbsPris = indkøbspris;
            IndkøbsPrisIalt = indkøbsprisialt;
        }

        public Salg()
        {

        }

    }
}
