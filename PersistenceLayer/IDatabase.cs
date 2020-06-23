using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public interface IDatabase
    {
        //Gem
        string GemEjer(Ejer e);

        string GemDyr(Dyr d);

        string GemBehandling(Behandling b);

        string GemFaktura(Faktura f);

        string GemSalgslinjer(Salgslinje salg);

        string GemBooking(Booking b);

        string GemBurBooking(BurBooking bb);

        string GemVenteliste(char statusAnkommet, int bookingID);

        //Opdater
        string OpdaterDyr(Dyr d);

        string OpdaterFaktura(Faktura f);

        string OpdaterVenteliste(char statusAnkommet, int bookingID);

        string OpdatereAntalVarerPåLager(int antalkøbt, int salgID, char kommando);


        //Slet
        string SletDyr(int id);

        string SletFaktura(int fakturaId);

        string SletSalgslinjer(int fakturaId);

        string SletTid(int id);

        //Hent
        Ejer HentEjer(int tlf);

        List<Dyr> HentDyr(int EjerTlf);

        List<Behandling> HentBehandling(int DyreID);

        List<Dyrlæge> HentDyrlæger();

        List<TypeSalg> HentListeMedTypeSalg();

        List<Salg> HentListeMedSalg(int typeID);

        List<Faktura> HentAlleFaktura();

        List<Salgslinje> HentSalgsLinjer(int FakturaID);

        List<Booking> HentBookedeTider(string dato, int dyrlægeID);

        List<int> HentLedigeBure(string startDato, string datoDag2, string datoDag3, string slutDato, string dyreType);

        List<Booking> HentAlleBookingUdFraTlf(int ejerTlf);

        List<Booking> HentAlleOperationerUdFraTlf(int ejerTlf);

        int HentNyesteBookingNr();

        List<Salg> HentLagerStatus();

        List<Salg> HentLagerMinLagerStatus();

        string Medicinpriser(string varenummer, decimal indkøbspris, decimal salgspris);

        List<Booking> HentAlleBookingUdFraDato(string dato);

        List<Booking> HentAlleBookingUdFraDatoOgLæge(string dato, int lægeID);

        char HentVenteListeStatus(int bookingID);

        List<String> HentDemSomVenterTilLæge(int lægeID);

        List<String> HentDemSomVenter();

        List<KontrolOplysninger> HentBookingerTilKontrolList(string dato);

        BurBooking Hent1BurBookings(int operationID);

    }
}
