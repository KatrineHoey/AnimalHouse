using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Venteliste
    {
        Controller c = new Controller();
        List<Dyrlæge> dyrlægeliste = new List<Dyrlæge>();
        
        public DataTable VentelisteDataTable(string dato, string lægenavn)
        {
            //Opret en ny datatabel:
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("BookingID", typeof(String));
            dataTable.Columns.Add("Ankommet", typeof(String));
            dataTable.Columns.Add("Tidspunkt", typeof(String));
            dataTable.Columns.Add("Navn", typeof(String));
            dataTable.Columns.Add("Tlf", typeof(String));
            dataTable.Columns.Add("Behandlingstype", typeof(String));
            dataTable.Columns.Add("Kommentar", typeof(String));
            dataTable.Columns.Add("Dyrlæge", typeof(String));


            List<Booking> bookinger = new List<Booking>();
            if (lægenavn == "Alle" || lægenavn == "")
            {
                //Hent alle bookinger ud fra en angivet dato. 
                bookinger = c.HentAlleBookingUdFraDato(dato);

                //Henter alle læger frem. 
                dyrlægeliste = c.HentLægeListe();
            }
            else
            {
                int dyrlægeID = FindLægeID(lægenavn); //Finder lægeID

                //Hent alle bookinger ud fra en angivet dato og angivet lægevalg. 
                bookinger = c.HentAlleBookingUdFraDatoOgLæge(dato, dyrlægeID);
            }
            


            foreach (Booking booking in bookinger)
            {
                //Henter ejeres navn:
                Ejer ejer = c.VisEjer(booking.Ejertlf);

                //Henter status på ankomst:
                char status = c.HentVentelisteStatus(booking.ID);
                string statusString = "Ikke ankommet";

                if (status == ' ')
                {
                    c.GemVenteliste('n', booking.ID);
                    statusString = "Ikke ankommet";
                }
                else if(status == 'n')
                {
                    statusString = "Ikke ankommet";
                }
                else if (status == 'v')
                {
                    statusString = "Venter";
                }
                else if (status == 'i')
                {
                    statusString = "Inde";
                }
                else if (status == 'a')
                {
                    statusString = "Afsluttet";
                }

                //Henter dyrelægenavn:
                string dyrlægenavn = "";
                
                foreach (Dyrlæge dyrlæge in dyrlægeliste)
                {
                    if (dyrlæge.ID == booking.DyrlægeID)
                    {
                        dyrlægenavn = dyrlæge.Navn;
                    }
                }

                //Indsætter dataerne i datagridviewet. 
                dataTable.Rows.Add(booking.ID, statusString, booking.Klokkeslæt, ejer.Navn, booking.Ejertlf, booking.BehandlingsType, booking.Kommentar, dyrlægenavn);
            }
            return dataTable;
        }

        public List<String> EjereSomVenter(string lægenavn)
        {
            List<String> venter;
            if (lægenavn == "Alle" || lægenavn == "")
            {
                //Hent alle bookinger ud fra en angivet dato. 
                venter = c.HentDemSomVenter();
            }
            else
            {
                int dyrlægeID = FindLægeID(lægenavn); //Finder lægeID

                //Hent alle bookinger ud fra en angivet dato og angivet lægevalg. 
                venter = c.HentDemSomVenterTilLæge(dyrlægeID);
            }

            return venter;
        }

        public int FindLægeID(string lægenavn)
        {
            //Henter alle læger frem. 
            dyrlægeliste = c.HentLægeListe();

            int dyrlægeID = 0;
            foreach (Dyrlæge dyrlæge in dyrlægeliste)
            {
                if (dyrlæge.Navn == lægenavn)
                {
                    dyrlægeID = dyrlæge.ID; //Finder den valgte dyrlæges ID.
                }
            }
            return dyrlægeID;
        }

    }
}
