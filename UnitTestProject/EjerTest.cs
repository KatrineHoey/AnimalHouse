using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using EntityLayer;
using PersistenceLayer;

namespace UnitTestProject
{
    [TestClass]
    public class EjerTest
    {
        DummyDatabase dd = new DummyDatabase();


        //Create
        [TestMethod]
        public void TestOpretEjerTrue()
        { //Katrine
            string navn = "Test Navn";
            int telefon = 12345678;
            string email = "Test@ucl.dk";
            string adresse = "Testvej 12";
            int postNr = 7100;
            string bynavn = "Vejle";
            char erhvervPrivate = 'e';
            char aktivinaktiv = 'a';

            Ejer ejer = new Ejer(navn, telefon, email, adresse, postNr, bynavn, erhvervPrivate, aktivinaktiv);

            bool actual = dd.OpretEjer(ejer); 
            Assert.AreEqual(true, actual); //Tjekker om metoden giver den forventede værdi. En true, ejeren har parameter med.

        }

        [TestMethod]
        public void TestOpretEjerFalse()
        { //Katrine

            Ejer ejer = new Ejer();

            bool actual = dd.OpretEjer(ejer);
            Assert.AreEqual(false, actual); //Tjekker om metoden giver den forventede værdi. En false, ejeren har ingen parameter med.

        }


        //Read
        [TestMethod]
        public void TestHentEjerTrue()
        { //Katrine
            dd.ÆndreEjereListen();
            int tlf = 12345678;
            bool actual = dd.HentEjer(tlf);
            Assert.AreEqual(true, actual); //Tjekker om metoden giver den forventede værdi. 

        }


        [TestMethod]
        public void TestHentEjerFalse()
        { //Katrine

            int tlf = 87654321;
            bool actual = dd.HentEjer(tlf);
            Assert.AreEqual(false, actual); //Tjekker om metoden giver den forventede værdi. 

        }

        //Update
        [TestMethod]
        public void TestOpdaterEjerTrue()
        {//Katrine
            dd.ÆndreEjereListen();

            string navn = "Test Navn2";
            int telefon = 12345678;
            string email = "Test2@ucl.dk";
            string adresse = "Testvej 12";
            int postNr = 7100;
            string bynavn = "Vejle";
            char erhvervPrivate = 'e';
            char aktivinaktiv = 'a';

            Ejer ejer = new Ejer(navn, telefon, email, adresse, postNr, bynavn, erhvervPrivate, aktivinaktiv);
            bool actual = dd.OpdaterEjer(ejer);
            Assert.AreEqual(true, actual); //Tjekker om metoden giver den forventede værdi. 

        }


        [TestMethod]
        public void TestOpdaterEjerFalse()
        {//Katrine

            Ejer ejer = new Ejer();
            bool actual = dd.OpdaterEjer(ejer);
            Assert.AreEqual(false, actual); //Tjekker om metoden giver den forventede værdi. 

        }


        //Slet
        [TestMethod]
        public void TestSletEjerTrue()
        {//Katrine
            dd.ÆndreEjereListen();
            int tlf = 12345678;
            bool actual = dd.HentEjer(tlf);
            Assert.AreEqual(true, actual); //Tjekker om metoden giver den forventede værdi. 

        }


        [TestMethod]
        public void TestSletEjerFalse()
        {//Katrine

            int tlf = 87654321;
            bool actual = dd.HentEjer(tlf);
            Assert.AreEqual(false, actual); //Tjekker om metoden giver den forventede værdi. 

        }

    }
}
