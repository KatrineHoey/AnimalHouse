using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BurBooking
    {
        public int ID { get; set; }
        public string StartDato { get; set; }
        public string DatoDag2 { get; set; }
        public string DatoDag3 { get; set; }
        public string SlutDato { get; set; }
        public int BurID { get; set; }
        public int OperationID { get; set; }

        public BurBooking(string startDato, string datoDag2, string datoDag3, string slutDato, int burID, int operationID)
        {
            StartDato = startDato;
            DatoDag2 = datoDag2;
            DatoDag3 = datoDag3;
            SlutDato = slutDato;
            BurID = burID;
            OperationID = operationID;
        }

        public BurBooking()
        {
        }
    }
}
