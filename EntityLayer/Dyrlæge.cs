using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Dyrlæge
    {//Katrine
        public int ID { get; set; }
        public string Navn { get; set; }

        public Dyrlæge()
        {

        }

        public Dyrlæge(int id, string navn)
        {
            ID = id;
            Navn = navn;
        }
    }
}
