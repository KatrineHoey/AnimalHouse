using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Behandling 
    {
        public int ID { get; set; }
        public string DatoPåBehandling { get; set; }
        public string UdførtAf { get; set; }
        public string Diagnose { get; set; }
        public string Behandlingstype { get; set; }
        public int Dyr { get; set; }

        public Behandling (string datoPåBehandling, string udførtAf, string diagnose, string behandlingstype, int dyr)
        {
            DatoPåBehandling = datoPåBehandling;
            UdførtAf = udførtAf;
            Diagnose = diagnose;
            Behandlingstype = behandlingstype;
            Dyr = dyr;
        }

        public Behandling()
        {

        }
    }
}
