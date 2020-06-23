using PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class PersistenceFactory
    { //Katrine
        private static PersistenceFactory instans;
        public static PersistenceFactory Instans() //Singelton-pattern
        {
            if (instans == null)
            {
                instans = new PersistenceFactory();
            }
            return instans;
        }

        private PersistenceFactory()
        {

        }

        public IDatabase HentPersistens(int valg)
        {
            if (valg == 1)
            {
                return new MicrosoftSQLServerManager();
            }
            else
            {
                //return new MySQLDatabaseManager();
                return new MicrosoftSQLServerManager();
            }
        }
    }
}
