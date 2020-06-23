using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class KontrolOplysninger
    {
        public string Dato { get; set; }
        public int Ejertlf { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int PostNr { get; set; }
        public string ByNavn { get; set; }
        public string DyrNavn { get; set; }
        public char AktivInaktiv { get; set; }

        public KontrolOplysninger (string dato, int ejertlf, string navn, string email, string adresse, int postnr, string bynavn, string dyrnavn, char aktivInaktiv)
        {
            Dato = dato;
            Ejertlf = ejertlf;
            Navn = navn;
            Email = email;
            Adresse = adresse;
            PostNr = postnr;
            ByNavn = bynavn;
            DyrNavn = dyrnavn;
            AktivInaktiv = aktivInaktiv;
        }
        public KontrolOplysninger ()
        {

        }
    }

}
