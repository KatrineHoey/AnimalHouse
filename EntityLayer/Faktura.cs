using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Faktura
    {
        public int ID { get; set; }
        public string Dato { get; set; }
        public int EjerTlf { get; set; }
        public bool Betalt { get; set; }

        public Faktura(string dato, int ejerTlf, bool betalt)
        {
            Dato = dato;
            EjerTlf = ejerTlf;
            Betalt = betalt;
        }

        public Faktura()
        {

        }
    }
}
