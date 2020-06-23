
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace BLL
{
    class BookingOgBurBooking
    {
        Controller c = new Controller();
        List<Booking> bookingliste = new List<Booking>();

        //DataTable: Repræsenterer værdier fra en database i et ”grid form” (her DataGridView). 
        //Her bruges en DataTable til at samle data fra Booking og BurBooking i et dataGridView.
        public DataTable BookingBBDataTable(int ejertlf, int søg)
        {
            if (søg == 1)
            {
                bookingliste = c.HentAlleOperationerUdFraTlf(ejertlf);
            }
            else
            {
                bookingliste = c.HentAlleBookingUdFraTlf(ejertlf);
            }

            
            //Oprettelse af kolonner til data fra booking og burbooking
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("BookingID", typeof(String));
            dataTable.Columns.Add("Dato", typeof(String));
            dataTable.Columns.Add("Klokkeslæt", typeof(String));
            dataTable.Columns.Add("Kommentar", typeof(String));
            dataTable.Columns.Add("DyrlægeID", typeof(String));
            dataTable.Columns.Add("BehandlingsType", typeof(String));
            dataTable.Columns.Add("BurID", typeof(String));
            dataTable.Columns.Add("startDato", typeof(String));
            dataTable.Columns.Add("slutDato", typeof(String));

            //BurBooking burbooking = new BurBooking();
            //burbooking = c.HentAlleBurBookings(operationID);

            //Data fra booking og burbooking indsættes i DataTable
            foreach (Booking booking in bookingliste)
            {
                BurBooking burbooking = c.HentAlleBurBookings(booking.ID);
                dataTable.Rows.Add(booking.ID, booking.Dato, booking.Klokkeslæt, booking.Kommentar, booking.DyrlægeID, booking.BehandlingsType, burbooking.BurID, burbooking.StartDato, burbooking.SlutDato);
            }

            
            return dataTable;
        }
    }
}
