using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace UnitTestProject
{
    [TestClass]
    public class IndkaldelseDatoTest
    {// Ibrahim
        // Henter en instance af indkaldelses controller.
        IndkaldelseController indkaldelseController = new IndkaldelseController();

        [TestMethod]
        public void TestTid()
        {
            // Definere dagensdato
            DateTime dagensDato = DateTime.Today;

            // Den aktuelle dato fra indkaldelsescontroller konverteres så den bliver (yyyy-MM-dd)
            string actual = indkaldelseController.KonvetereIndkaldelsesDag(dagensDato);

            // Trækker 365 dage fra dagensdato og konverter til en string
            DateTime etÅrTilbage = dagensDato.AddDays(-365);
            string etÅrString = etÅrTilbage.ToString("yyyy-MM-dd");

            // Sammenligner de 2 datoer
            Assert.AreEqual(etÅrString, actual);
        }
    }
}
