using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class DummyDatabase
    {
        public List<Ejer> ejere = new List<Ejer>();

        public void ÆndreEjereListen()
        {
            string navn = "Test Navn";
            int telefon = 12345678;
            string email = "Test@ucl.dk";
            string adresse = "Testvej 12";
            int postNr = 7100;
            string bynavn = "Vejle";
            char erhvervPrivate = 'e';
            char aktivinaktiv = 'a';

            Ejer ejer = new Ejer(navn, telefon, email, adresse, postNr, bynavn, erhvervPrivate, aktivinaktiv);
            ejere.Add(ejer);
        }

        public bool OpretEjer(Ejer ejer)
        {
            if (ejer.Telefon == 0)
            {
                return false;
            }
            else
            {
                ejere.Add(ejer);
                return true;
            }
        }

        public bool HentEjer(int tlf)
        {
            foreach (Ejer ejer in ejere)
            {
                if (ejer.Telefon == tlf)
                {
                    return true;
                }
            }
            return false;
        }

        public bool OpdaterEjer(Ejer e)
        {
            foreach (Ejer ejer in ejere)
            {
                if (ejer.Telefon == e.Telefon)
                {
                    ejer.Navn = e.Navn;
                    ejer.Email = e.Email;
                    //osv.
                    return true;
                }
            }
            return false;
        }

        public bool SletEjer(int tlf)
        {
            foreach (Ejer ejer in ejere)
            {
                if (ejer.Telefon == tlf)
                {
                    ejere.Remove(ejer);
                    return true;
                }
            }
            return false;
        }
    }
}
