using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Salgslinje
    {
        public int ID { get; set; }
        public int Antal { get; set; }
        public int SalgID { get; set; }
        public string SalgsBeskrivelse { get; set; }
        public int FakturaID { get; set; }
        public decimal Pris { get; set; }

        public Salgslinje(int antal, int salgID, int fakturaID, decimal pris)
        {
            Antal = antal;
            SalgID = salgID;
            FakturaID = fakturaID;
            Pris = pris;
        }

        public Salgslinje()
        {

        }
    }
}
