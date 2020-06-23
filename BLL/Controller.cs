using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using PersistenceLayer;
using System.Data;
using System.IO;

namespace BLL
{
    public class Controller
    {
        IDatabase idatabase;

        public Controller()
        {
            PersistenceFactory persistenceFactory = PersistenceFactory.Instans();
            idatabase = persistenceFactory.HentPersistens(1); //Fortæller hvilken database der skal vælges. 
        }

        //Gem objekter i databasen:
        public void OpretEjer(string navn, int tlf, string email, string adresse, int postnr, string bynavn, char erhvervPrivate, char aktivInaktiv)
        {//Katrine
            Ejer ejer = new Ejer(navn, tlf, email, adresse, postnr, bynavn, erhvervPrivate, aktivInaktiv);
            idatabase.GemEjer(ejer);
        }

        public void TilføjDyr(string navn, string dyretype, int fødselsår, string køn, double vægt, string kommentar, int ejer, int dyrlæge)
        {//Katrine
            Dyr dyr = new Dyr(navn, dyretype, fødselsår, køn, vægt, kommentar, ejer, dyrlæge);
            idatabase.GemDyr(dyr);
        }

        public void RegistrerBehandling(string datoPåBehandling, string udførtAf, string diagnose, string behandlingstype, int dyr)
        {//Katrine
            Behandling behandling = new Behandling(datoPåBehandling, udførtAf, diagnose, behandlingstype, dyr);
            idatabase.GemBehandling(behandling);
        }

        public void GemFaktura(string dato, int ejerTlf, bool betalt)
        {//Katrine
            Faktura faktura = new Faktura(dato, ejerTlf, betalt);
            idatabase.GemFaktura(faktura);
        }

        public void GemSalgslinje(int antal, int salgID, int fakturaID, decimal pris)
        {//Katrine
            Salgslinje salgslinje = new Salgslinje(antal, salgID, fakturaID, pris);
            idatabase.GemSalgslinjer(salgslinje);
        }

        public string BestilTid(string kommentar, string dato, string klokkeslæt, int ejertlf, int dyrlægeID, string behandlingsType)
        { //Irfan
            Booking booking = new Booking(kommentar, dato, klokkeslæt, ejertlf, dyrlægeID, behandlingsType);
            string lykkes = idatabase.GemBooking(booking);
            return lykkes;
        }

        public void GemVenteliste(char statusAnkommet, int bookingID)
        { //Katrine
            idatabase.GemVenteliste(statusAnkommet, bookingID);
        }

        public void BookBur(string startDato, string datoDag2, string datoDag3, string slutDato, int burID, int operationID)
        { //Irfan
            BurBooking burbooking = new BurBooking(startDato, datoDag2, datoDag3, slutDato, burID, operationID);
            idatabase.GemBurBooking(burbooking);
        }


        //Opdatere objekter i databasen
        public void OpdaterDyr(int id, string navn, string dyretype, int fødselsår, string køn, double vægt, string kommentar, int ejer, int dyrlæge)
        {//Line
            Dyr dyr = new Dyr(navn, dyretype, fødselsår, køn, vægt, kommentar, ejer, dyrlæge);
            dyr.ID = id;
            idatabase.OpdaterDyr(dyr);
        }


        //indlæs medicinpriser
        public void IndlæsMedicinPriser(string varenummer, decimal indkøbspris, decimal salgspris)
        {//Ibrahim
            idatabase.Medicinpriser(varenummer, indkøbspris, salgspris);
        }

        public void OpdaterFaktura(int fakturaID, string dato, int ejerTlf, bool betalt)
        { //Katrine
            Faktura faktura = new Faktura(dato, ejerTlf, betalt);
            faktura.ID = fakturaID;
            idatabase.OpdaterFaktura(faktura);
        }

        public void OpdaterVenteliste(string statusAnkommet, int bookingID)
        { //Katrine
            char status = ' ';
            if (statusAnkommet == "Afsluttet")
            {
                status = 'a';
            }
            else if (statusAnkommet == "Ikke ankommet")
            {
                status = 'n';
            }
            else if (statusAnkommet == "Venter")
            {
                status = 'v';
            }
            else if (statusAnkommet == "Inde")
            {
                status = 'i';
            }
            idatabase.OpdaterVenteliste(status, bookingID);
        }

        public void OpdatereAntalVarerPåLager(int antalkøbt, int salgID, char kommando)
        { //Katrine
            idatabase.OpdatereAntalVarerPåLager(antalkøbt, salgID, kommando);
        }


        //Hent objekter fra databasen:
        public Ejer VisEjer(int tlf)
        {//Katrine
            Ejer ejer = idatabase.HentEjer(tlf);
            return ejer;
        }

        public List<Dyr> VisDyr(int ejerID)
        {//Katrine
            List<Dyr> dyreliste = idatabase.HentDyr(ejerID);
            return dyreliste;
        }

        public List<Behandling> VisBehandlinger(int dyreID)
        {//Katrine
            List<Behandling> behandlingsliste = idatabase.HentBehandling(dyreID);
            return behandlingsliste;
        }

        public List<Dyrlæge> HentLægeListe()
        {//Katrine
            List<Dyrlæge> dyrlæger = idatabase.HentDyrlæger();
            return dyrlæger;
        }

        public List<TypeSalg> HentTypeSalg()
        {//Katrine
            List<TypeSalg> typesalgsliste = idatabase.HentListeMedTypeSalg();
            return typesalgsliste;
        }

        public List<Salg> HentSalg(int typeSalgID)
        {//Katrine
            List<Salg> salgsliste = idatabase.HentListeMedSalg(typeSalgID);
            return salgsliste;
        }

        public List<Faktura> HentAlleFaktura()
        {//Katrine
            List<Faktura> fakturaer = idatabase.HentAlleFaktura();
            return fakturaer;
        }

        public List<Salgslinje> HentSalgslinjerFraFaktura(int FakturaID)
        {//Katrine
            List<Salgslinje> salgslinjer = idatabase.HentSalgsLinjer(FakturaID);
            return salgslinjer;
        }

        public List<Booking> HentBookedeTider(string dato, int dyrlægeID)
        { //Irfan
            List<Booking> bookinger = idatabase.HentBookedeTider(dato, dyrlægeID);
            return bookinger;
        }

        public List<int> HentLedigeBure(string startDato, string datoDag2, string datoDag3, string slutDato, string dyreType)
        { //Irfan
            List<int> burnumre = idatabase.HentLedigeBure(startDato, datoDag2, datoDag3, slutDato, dyreType);
            return burnumre;
        }

        public List<Booking> HentAlleBookingUdFraTlf(int ejerTlf)
        { //Irfan
            List<Booking> bookinger = idatabase.HentAlleBookingUdFraTlf(ejerTlf);
            return bookinger;
        }

        public int HentNyesteBookingNr()
        { //Irfan
            int id = idatabase.HentNyesteBookingNr();
            return id;
        }

        public List<Booking> HentAlleBookingUdFraDato(string dato)
        { //Katrine
            List<Booking> bookinger = idatabase.HentAlleBookingUdFraDato(dato);
            return bookinger;
        }

        public List<Booking> HentAlleBookingUdFraDatoOgLæge(string dato, int lægeID)
        { //Katrine
            List<Booking> bookinger = idatabase.HentAlleBookingUdFraDatoOgLæge(dato, lægeID);
            return bookinger;
        }

        public List<Booking> HentAlleOperationerUdFraTlf(int ejerTlf)
        { //Irfan
            List<Booking> bookinger = idatabase.HentAlleOperationerUdFraTlf(ejerTlf);
            return bookinger;
        }

        public char HentVentelisteStatus(int bookingID)
        { //Katrine
            char status = idatabase.HentVenteListeStatus(bookingID);
            return status;
        }

        public DataTable HentDatatableVenteliste(string dato, string lægevalg)
        { //Katrine
            Venteliste venteliste = new Venteliste();
            DataTable dataTable = venteliste.VentelisteDataTable(dato, lægevalg);
            return dataTable;
        }

        public List<Salg> HentLagerStatus()
        {//Line
            List<Salg> lager = idatabase.HentLagerStatus ();
            return lager;
        }

        public List<Salg> HentLagerMinLagerStatus()
        {//Line
            List<Salg> lagermin = idatabase.HentLagerMinLagerStatus();
            return lagermin;
        }

        public List<string> HentNavnPåEjerSomVenter(string lægevalg)
        { //Katrine
            Venteliste venteliste = new Venteliste();
            List<string> venter = venteliste.EjereSomVenter(lægevalg);
            return venter;
        }

        public List<String> HentDemSomVenterTilLæge(int lægeID)
        { //Katrine
            List<String> venter = idatabase.HentDemSomVenterTilLæge(lægeID);
            return venter;
        }

        public List<String> HentDemSomVenter()
        { //Katrine
            List<String> venter = idatabase.HentDemSomVenter();
            return venter;
        }

        public BurBooking HentAlleBurBookings(int operationID)
        { // Irfan
            BurBooking burbooking = idatabase.Hent1BurBookings(operationID);
            return burbooking;
        }


        //Slet objekter fra databasen:
        public void SletFaktura(int FakturaID)
        {//Katrine
            idatabase.SletFaktura(FakturaID);
        }

        public void SletTid(int ID)
        {//Irfan
            idatabase.SletTid(ID);
        }

        public void SletSalgslinjer(int FakturaID)
        { //Katrine
            idatabase.SletSalgslinjer(FakturaID);
        }
        
        public void SletDyr(int id)
        {//Line

            idatabase.SletDyr(id);
        }

        public List<KontrolOplysninger> HentBookingerTilKontrolListe(string indkaldelsedatoString)
        {//Ibrahim
            List<KontrolOplysninger> kontrolOplysninger = idatabase.HentBookingerTilKontrolList(indkaldelsedatoString);

            return kontrolOplysninger;
        }

        public string KonvetereDag(DateTime dagensDato)
        {//Ibrahim
            IndkaldelseController indkaldelsesController = new IndkaldelseController();
           string indkaldelseDato =  indkaldelsesController.KonvetereIndkaldelsesDag(dagensDato);

            return indkaldelseDato;
        }

        public DataTable BookingBBDataTable(int ejertlf, int søg)
        { //Irfan
            BookingOgBurBooking bookingOgBurbooking = new BookingOgBurBooking();
            DataTable dataTable = bookingOgBurbooking.BookingBBDataTable(ejertlf, søg);
            return dataTable;
        }
    }
}
