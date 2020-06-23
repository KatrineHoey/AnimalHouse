using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using PersistenceLayer;


namespace BLL
{
    public class IndkaldelseController
    {// Ibrahim

        // Får dagens dato og returner som datoen som string
        public string KonvetereIndkaldelsesDag(DateTime dagensDato)
        {
            DateTime indkaldelseDato = dagensDato.AddDays(-365);
            string indkaldelsedatoString = indkaldelseDato.ToString("yyyy-MM-dd");

            return indkaldelsedatoString;
        }
    }
}
