using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    // Line
    public class Ejer
    {
        public string Navn { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int PostNr { get; set; }
        public string ByNavn { get; set; }
        public char ErhvervPrivat { get; set; }
        public char AktivInaktiv { get; set; }

        public Ejer (string navn, int tlf, string email, string adresse, int postnr, string bynavn, char erhvervPrivate, char aktivInaktiv)
        {
            Navn = navn;
            Telefon = tlf;
            Email = email;
            Adresse = adresse;
            PostNr = postnr;
            ByNavn = bynavn;
            ErhvervPrivat = erhvervPrivate;
            AktivInaktiv = aktivInaktiv;
        }
        public Ejer ()
        {

        }
    }
}
