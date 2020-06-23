using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class MicrosoftSQLServerManager : IDatabase
    {
        SqlConnection conn;
        SqlCommand com;
        
        //Forbindelsen
        private string HentForbindelsesString()
        { //Katrine
            return "Data Source=den1.mssql8.gear.host; Initial Catalog=animalhouseucl; User Id=animalhouseucl; Password=Kr0suY91u??2";
        }

        private string ÅbenOgLukForbindelse(string kommando)
        { //Katrine
            try
            {
                conn = new SqlConnection(HentForbindelsesString());
                conn.Open();
                com = new SqlCommand(kommando, conn);
                com.ExecuteNonQuery();
                return "Data er gemt";
            }
            catch (Exception ex)
            {
                return ("Der er sket en fejl i din SQL\n" +
                                ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        public string GemEjer(Ejer e)
        { //Katrine
            string kommandoString = $"insert into Ejer(erhvervPrivat, navn, adresse, postnummer, bynavn, tlf, email, aktivInaktiv) values ('{e.ErhvervPrivat}','{e.Navn}','{e.Adresse}',{e.PostNr},'{e.ByNavn}', {e.Telefon},'{e.Email}','{e.AktivInaktiv}')";
            string ok = ÅbenOgLukForbindelse(kommandoString);

         // Metode til at opdatere ejeren, hvis der er ændringer i ejer oplysninger.
            if (ok != "Data er gemt")
            {
               kommandoString = $"Update Ejer set tlf = '{e.Telefon}', navn = '{e.Navn}', adresse = '{e.Adresse}',postnummer = '{e.PostNr}'," +
                $"bynavn = '{e.ByNavn}', email = '{e.Email}', erhvervPrivat = '{e.ErhvervPrivat}', aktivInaktiv = '{e.AktivInaktiv}'where tlf = '{e.Telefon}'";
                ok = ÅbenOgLukForbindelse(kommandoString);
            }
            return ok;
        }

        public string GemDyr(Dyr d)
        {//Katrine

           string kommandoString = $"insert into Dyr(dyrNavn, dyretype, fødselsår, køn, vægt, kommentar, ejer, dyrlæge) values ('{d.Navn}','{d.DyreType}',{d.Fødselsår},'{d.Køn}',{d.Vægt}, '{d.Kommentar}',{d.Ejer}, {d.Dyrlæge})";
           string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemBehandling(Behandling b)
        {//Katrine
            string kommandoString = $"insert into Behandling(datoPåBehandling, diagnose, behandling, udførtAf, dyr) values ('{b.DatoPåBehandling}','{b.Diagnose}','{b.Behandlingstype}','{b.UdførtAf}',{b.Dyr})";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemFaktura(Faktura f)
        {//Katrine
            string kommandoString = $"Insert into Faktura(dato, ejer, betalt) values ('{f.Dato}', {f.EjerTlf}, '{f.Betalt}')";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemSalgslinjer(Salgslinje salg)
        {//Katrine
            string kommandoString = $"Insert into Salgslinjer(antal, pris, salg, faktura) values({salg.Antal}, '{salg.Pris}', {salg.SalgID}, {salg.FakturaID}) ";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemBooking(Booking b)
        { // Irfan
            string kommandoString = $"Insert into Booking(dato, klokkeslæt, kommentar, dyrlægeID, ejertlf, behandlingstype) values('{b.Dato}', '{b.Klokkeslæt}', '{b.Kommentar}', {b.DyrlægeID}, {b.Ejertlf}, '{b.BehandlingsType}') ";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemBurBooking(BurBooking bb)
        {
            string kommandoString = $"Insert into BurBooking(startDato, datoDag2, datoDag3, slutDato, BurID, OperationID) values('{bb.StartDato}', '{bb.DatoDag2}', '{bb.DatoDag3}', '{bb.SlutDato}', '{bb.BurID}', {bb.OperationID}) ";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string GemVenteliste(char statusAnkommet, int bookingID)
        {//Katrine
            string kommandoString = $"insert into Venteliste(ankommet, bookingID) values ('{statusAnkommet}', {bookingID})";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }


        public string OpdaterDyr(Dyr d)
        {//Line
            string kommandoString = $"Update Dyr set dyrNavn = '{d.Navn}', dyretype = '{d.DyreType}',fødselsår = '{d.Fødselsår}'," +
            $"køn = '{d.Køn}', vægt = '{d.Vægt}', kommentar = '{d.Kommentar}', ejer = '{d.Ejer}', dyrlæge = '{d.Dyrlæge}' where id = '{d.ID}'";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string OpdaterFaktura(Faktura f)
        {//Katrine
            string kommandoString = $"Update Faktura set dato = '{f.Dato}', ejer = {f.EjerTlf}, betalt = '{f.Betalt}' where id = '{f.ID}'";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string OpdaterVenteliste(char statusAnkommet, int bookingID)
        {//Katrine
            string kommandoString = $"update Venteliste set ankommet = '{statusAnkommet}' where bookingID = {bookingID}";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string OpdatereAntalVarerPåLager(int antalkøbt, int salgID, char kommando)
        {//Katrine
            string kommandoString = $"update Salg set antal = (antal {kommando} {antalkøbt}) where id = {salgID}";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string SletDyr(int id)
        {//Line
            // Slet fra behandling på id dyr
            
            string kommandoString = $"Delete FROM Behandling where dyr = '{id}'" +
                $"Delete FROM Dyr where id = '{id}'";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }



        public string SletFaktura(int fakturaId)
        {//Katrine
            string kommandoString = $"Delete from Salgslinjer where faktura = {fakturaId}" +
                $"Delete FROM Faktura where id = '{fakturaId}'";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string SletSalgslinjer(int fakturaId)
        {//Katrine
            string kommandoString = $"Delete from Salgslinjer where faktura = {fakturaId}";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }

        public string SletTid(int id)
        {// Irfan
            string kommandoString = $"Delete FROM Booking where id = '{id}'";
            string ok = ÅbenOgLukForbindelse(kommandoString);
            return ok;
        }


        public Ejer HentEjer(int tlf)
        {//Katrine
            string SelectSqlString = $"select * from Ejer where tlf = {tlf}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Ejer ejer = new Ejer(); ;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                    ejer = new Ejer(reader["navn"].ToString(),
                    Convert.ToInt32(reader["tlf"]),
                    reader["email"].ToString(),
                    reader["adresse"].ToString(),
                    Convert.ToInt32(reader["postnummer"]),
                    reader["bynavn"].ToString(),
                    Convert.ToChar(reader["erhvervPrivat"]),
                    Convert.ToChar(reader["aktivInaktiv"]));
            }
            reader.Close();
            conn.Close();
            return ejer;
        }
        public List<Dyr> HentDyr(int EjerTlf)
        {//Katrine
            List<Dyr> dyreliste = new List<Dyr>();
            string SelectSqlString = $"select * from Dyr where ejer = {EjerTlf}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Dyr dyr = new Dyr(); 
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                dyr = new Dyr(reader["dyrNavn"].ToString(),
                    reader["dyretype"].ToString(),
                    Convert.ToInt32(reader["fødselsår"]),
                    reader["køn"].ToString(),
                    Convert.ToDouble(reader["vægt"]),
                    reader["kommentar"].ToString(),
                    Convert.ToInt32(reader["ejer"]),
                    Convert.ToInt32(reader["dyrlæge"]));
                dyr.ID = Convert.ToInt32(reader["id"]);
                dyreliste.Add(dyr);
            }
            reader.Close();
            conn.Close();
            return dyreliste;
        }

        public List<Behandling> HentBehandling(int DyreID)
        {//Katrine
            List<Behandling> behandlingsliste = new List<Behandling>();
            string SelectSqlString = $"select * from Behandling where dyr = {DyreID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Behandling behandling = new Behandling();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                behandling = new Behandling(reader["datoPåBehandling"].ToString(),
                    reader["udførtAf"].ToString(),
                    reader["diagnose"].ToString(),
                    reader["behandling"].ToString(),
                    Convert.ToInt32(reader["dyr"]));
                behandling.ID = Convert.ToInt32(reader["id"]);
                behandlingsliste.Add(behandling);

            }
            reader.Close();
            conn.Close();
            return behandlingsliste;
        }

        public List<Dyrlæge> HentDyrlæger()
        {//Katrine
            List<Dyrlæge> dyrlæger = new List<Dyrlæge>();
            string SelectSqlString = $"select * from Dyrlæge";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Dyrlæge dyrlæge = new Dyrlæge();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                dyrlæge = new Dyrlæge(Convert.ToInt32(reader["id"]),
                    reader["navn"].ToString());
                dyrlæger.Add(dyrlæge);
            }
            reader.Close();
            conn.Close();
            return dyrlæger;
        }

        public List<TypeSalg> HentListeMedTypeSalg()
        {//Katrine
            List<TypeSalg> typesalg = new List<TypeSalg>();
            string SelectSqlString = $"select * from TypeSalg";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            TypeSalg typeSalg = new TypeSalg();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                typeSalg = new TypeSalg();
                typeSalg.ID = Convert.ToInt32(reader["id"]);
                typeSalg.Beskrivelse = reader["beskrivelse"].ToString();
                typesalg.Add(typeSalg);
            }
            reader.Close();
            conn.Close();
            return typesalg;
        }

        public List<Salg> HentListeMedSalg(int typeID)
        {//Katrine
            List<Salg> salgsliste = new List<Salg>();
            string SelectSqlString = $"select * from Salg where typesalg = {typeID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Salg salg = new Salg();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                salg = new Salg();
                salg.ID = Convert.ToInt32(reader["id"]);
                salg.Beskrivelse = reader["beskrivelse"].ToString();
                salg.Pris = Convert.ToDecimal(reader["pris"]);
                salg.Type = Convert.ToInt32(reader["typesalg"]);
                if (reader["Antal"].ToString() != "")
                {
                    salg.Antal = Convert.ToInt32(reader["antal"]);
                }
                
                salgsliste.Add(salg);
            }
            reader.Close();
            conn.Close();
            return salgsliste;
        }

        public List<Faktura> HentAlleFaktura()
        {//Katrine
            List<Faktura> Fakturaliste = new List<Faktura>();
            string SelectSqlString = $"select * from Faktura order by id desc";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);            
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Faktura faktura = new Faktura();
                faktura.ID = Convert.ToInt32(reader["id"]);
                faktura.Dato = reader["dato"].ToString();
                faktura.EjerTlf = Convert.ToInt32(reader["ejer"]);
                faktura.Betalt = Convert.ToBoolean(reader["betalt"]);
                Fakturaliste.Add(faktura);
            }
            reader.Close();
            conn.Close();
            return Fakturaliste;
        }

        public List<Salgslinje> HentSalgsLinjer(int FakturaID)
        {//Katrine
            List<Salgslinje> Salgslinjer = new List<Salgslinje>();
            string SelectSqlString = $"select sl.id, sl.salg, s.beskrivelse, sl. antal, sl.pris, sl.faktura from Salgslinjer sl " +
                $"left join Salg s on s.id = sl.salg " +
                $"where faktura = {FakturaID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Salgslinje salgslinje = new Salgslinje();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {   salgslinje = new Salgslinje();
                salgslinje.ID = Convert.ToInt32(reader["id"]);
                salgslinje.Antal = Convert.ToInt32(reader["antal"]);
                salgslinje.Pris = Convert.ToDecimal(reader["pris"]);
                salgslinje.SalgID = Convert.ToInt32(reader["salg"]);
                salgslinje.SalgsBeskrivelse = reader["beskrivelse"].ToString();
                salgslinje.FakturaID = Convert.ToInt32(reader["faktura"]);
                Salgslinjer.Add(salgslinje);
            }
            reader.Close();
            conn.Close();
            return Salgslinjer;
        }

        public List<Booking> HentBookedeTider(string dato, int dyrlægeID)
        { //Irfan
            List<Booking> bookings = new List<Booking>();
            string SelectSqlString = $"select * from Booking where Dato = '{dato}' and DyrlægeID = '{dyrlægeID}'";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Booking booking = new Booking();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                booking = new Booking();
                booking.Klokkeslæt = reader["klokkeslæt"].ToString();
                booking.BehandlingsType = reader["BehandlingsType"].ToString();
                bookings.Add(booking);
            }
            reader.Close();
            conn.Close();
            return bookings;
        }

        public List<int> HentLedigeBure(string startDato, string datoDag2, string datoDag3, string slutDato, string dyreType)
        { //Irfan
            List<int> burbookings = new List<int>();
            string SelectSqlString = $"select ID From Bur where DyreType = '{dyreType}' and Bur.ID NOT IN (select BurID FROM BurBooking where(startDato = '{startDato}' or slutDato = '{startDato}' or datoDag2 = '{startDato}' or datoDag3 = '{startDato}')" +
                $" or (startDato = '{datoDag2}' or slutDato = '{datoDag2}' or datoDag2 = '{datoDag2}' or datoDag3 = '{datoDag2}') or (startDato = '{datoDag3}' or slutDato = '{datoDag3}' or datoDag2 = '{datoDag3}' or datoDag3 = '{datoDag3}') " +
                $"or (startDato = '{slutDato}' or slutDato = '{slutDato}' or datoDag2 = '{slutDato}' or datoDag3 = '{slutDato}'))";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"]);
                burbookings.Add(id);
            }
            reader.Close();
            conn.Close();
            return burbookings;
        }

        public List<Booking> HentAlleBookingUdFraTlf(int ejerTlf)
        { //Irfan
            List<Booking> bookings = new List<Booking>();
            string SelectSqlString = $"select * from Booking where Ejertlf = {ejerTlf}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Booking booking = new Booking();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                booking = new Booking();
                booking.ID = Convert.ToInt32(reader["ID"].ToString());
                booking.Dato = reader["Dato"].ToString();
                booking.Klokkeslæt = reader["Klokkeslæt"].ToString();
                booking.DyrlægeID = Convert.ToInt32(reader["DyrlægeID"]);
                booking.Kommentar = reader["kommentar"].ToString();
                booking.BehandlingsType = reader["behandlingstype"].ToString();
                booking.Ejertlf = ejerTlf;
                bookings.Add(booking);
            }
            reader.Close();
            conn.Close();
            return bookings;
        }

        public List<Booking> HentAlleOperationerUdFraTlf(int ejerTlf)
        { //Irfan
            List<Booking> bookings = new List<Booking>();
            string SelectSqlString = $"select * from Booking where Ejertlf = {ejerTlf} and BehandlingsType = 'Operation'";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            Booking booking = new Booking();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                booking = new Booking();
                booking.ID = Convert.ToInt32(reader["ID"].ToString());
                booking.Dato = reader["Dato"].ToString();
                booking.Klokkeslæt = reader["Klokkeslæt"].ToString();
                booking.DyrlægeID = Convert.ToInt32(reader["DyrlægeID"]);
                booking.Kommentar = reader["kommentar"].ToString();
                booking.Ejertlf = ejerTlf;
                booking.BehandlingsType = reader["BehandlingsType"].ToString();
                bookings.Add(booking);
            }
            reader.Close();
            conn.Close();
            return bookings;
        }

        public int HentNyesteBookingNr()
        { //Irfan
            string SelectSqlString = $"select max(id) as id from Booking ";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            int id = 0;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
            }
            reader.Close();
            conn.Close();
            return id;
        }

        public BurBooking Hent1BurBookings(int operationID)
        { //Irfan
            string SelectSqlString = $"select * from BurBooking where OperationID = '{operationID}'";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            BurBooking burbooking = new BurBooking();
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                burbooking = new BurBooking();
                burbooking.OperationID = Convert.ToInt32(reader["OperationID"].ToString());
                burbooking.StartDato = reader["startDato"].ToString();
                burbooking.SlutDato = reader["slutDato"].ToString();
                burbooking.BurID = Convert.ToInt32(reader["BurID"]);
            }
            reader.Close();
            conn.Close();
            return burbooking;
        }

        public List<Salg> HentLagerStatus()
        {//Line
            List<Salg> LagerStatusListe = new List<Salg>();
            string SelectSqlString = $"select * from Salg where typesalg = 3 or typesalg = 4";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Salg lager = new Salg();
                lager.ID = Convert.ToInt32(reader["id"].ToString());
                lager.Beskrivelse = reader["beskrivelse"].ToString();
                lager.Pris = Convert.ToDecimal(reader["pris"].ToString());
                lager.Antal = Convert.ToInt32(reader["antal"].ToString());
                lager.Type = Convert.ToInt32(reader["typesalg"]);
                lager.IndkøbsPris = Convert.ToDecimal(reader["indkøbspris"]);
                LagerStatusListe.Add(lager);
            }
            reader.Close();
            conn.Close();
            return LagerStatusListe;
        }

        public List<Salg> HentLagerMinLagerStatus()
        {//Line
            List<Salg> LagerMinStatusListe = new List<Salg>();
            string SelectSqlString = $"select * from Salg where antal <= 10 and (typesalg = 3 or typesalg = 4)";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();            
            while (reader.Read())
            {
                {
                    Salg lager = new Salg();
                    lager.ID = Convert.ToInt32(reader["id"].ToString());
                    lager.Beskrivelse = reader["beskrivelse"].ToString();
                    lager.Pris = Convert.ToDecimal(reader["pris"].ToString());
                    lager.Antal = Convert.ToInt32(reader["antal"].ToString());
                    lager.Type = Convert.ToInt32(reader["typesalg"]);
                    lager.IndkøbsPris = Convert.ToDecimal(reader["indkøbspris"]);
                    LagerMinStatusListe.Add(lager);
                }
            }
            reader.Close();
            conn.Close();
            return LagerMinStatusListe;
        }

        public string Medicinpriser(string varenummer, decimal indkøbspris, decimal salgspris)
        { //Ibrahim
            string SelectSqlString = $"select * from medicinpriser where varenumer = '{varenummer}'";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            int id = 0;
            string ok = "";
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
            }
            reader.Close();
            conn.Close();

            //Opdater priserne:
            indkøbspris.ToString();
            salgspris.ToString();
            string kommandoString = $"Update Salg set indkøbspris = '{indkøbspris}', pris = '{salgspris}' where id = {id}";
            ok = ÅbenOgLukForbindelse(kommandoString);

            return ok;
        }


        public List<Booking> HentAlleBookingUdFraDato(string dato)
        { //Katrine
            List<Booking> bookings = new List<Booking>();
            string SelectSqlString = $"select * from Booking where Dato = '{dato}' order by klokkeslæt";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Booking booking = new Booking();
                booking.ID = Convert.ToInt32(reader["ID"].ToString());
                booking.Dato = reader["Dato"].ToString();
                booking.Klokkeslæt = reader["Klokkeslæt"].ToString();
                booking.DyrlægeID = Convert.ToInt32(reader["DyrlægeID"]);
                booking.BehandlingsType = reader["behandlingstype"].ToString();
                booking.Kommentar = reader["kommentar"].ToString();
                booking.Ejertlf = Convert.ToInt32(reader["Ejertlf"]);
                bookings.Add(booking);
            }
            reader.Close();
            conn.Close();
            return bookings;
        }

        public List<Booking> HentAlleBookingUdFraDatoOgLæge(string dato, int lægeID)
        { //Katrine
            List<Booking> bookings = new List<Booking>();
            string SelectSqlString = $"select * from Booking where Dato = '{dato}' and DyrlægeID = {lægeID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Booking booking = new Booking();
                booking.ID = Convert.ToInt32(reader["ID"].ToString());
                booking.Dato = reader["Dato"].ToString();
                booking.Klokkeslæt = reader["Klokkeslæt"].ToString();
                booking.DyrlægeID = Convert.ToInt32(reader["DyrlægeID"]);
                booking.BehandlingsType = reader["behandlingstype"].ToString();
                booking.Kommentar = reader["kommentar"].ToString();
                booking.Ejertlf = Convert.ToInt32(reader["Ejertlf"]);
                bookings.Add(booking);
            }
            reader.Close();
            conn.Close();
            return bookings;
        }

        public char HentVenteListeStatus(int bookingID)
        { //Katrine
            string SelectSqlString = $"select * from Venteliste where bookingID = {bookingID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            char status = ' ';
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                status = Convert.ToChar(reader["ankommet"]);
            }
            reader.Close();
            conn.Close();
            return status;
        }

        public List<String> HentDemSomVenterTilLæge(int lægeID)
        { //Katrine
            List<string> venter = new List<string>();
            string SelectSqlString = $"select e.navn from Venteliste v " +
                $"join Booking b on b.ID = v.bookingID " +
                $"join Ejer e on e.tlf = b.Ejertlf " +
                $"where ankommet = 'v' " +
                $"and b.DyrlægeID = {lægeID}";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string navn = Convert.ToString(reader["navn"]);
                venter.Add(navn);
            }
            reader.Close();
            conn.Close();
            return venter;
        }


        public List<String> HentDemSomVenter()
        { //Katrine
            List<string> venter = new List<string>();
            string SelectSqlString = $"select e.navn from Venteliste v " +
                $"join Booking b on b.ID = v.bookingID " +
                $"join Ejer e on e.tlf = b.Ejertlf " +
                $"where ankommet = 'v' ";
            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string navn = Convert.ToString(reader["navn"]);
                venter.Add(navn);
            }
            reader.Close();
            conn.Close();
            return venter;
        }

        public List<KontrolOplysninger> HentBookingerTilKontrolList(string dato)
        {//Ibrahim
            List<KontrolOplysninger> kontrolOplysningers = new List<KontrolOplysninger>();

            string SelectSqlString = $"select be.datopåbehandling, d.dyrnavn, e.tlf, e.navn, e.email, e.adresse, e.postnummer, e.aktivInaktiv, e.bynavn from behandling be" +
                $" inner join(" +
                $" select dyr, max(datopåbehandling) as MaxDate from behandling" +
                $" group by dyr" +
                $" ) b on b.dyr = be.dyr and be.datopåbehandling = b.MaxDate" +
                $" join dyr d on d.id = be.dyr" +
                $" join ejer e on e.tlf = d.ejer" +
                $" where be.datoPåBehandling <= '{dato}' and e.aktivInaktiv = 'a'";


            conn = new SqlConnection(HentForbindelsesString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                KontrolOplysninger kontrol = new KontrolOplysninger();
                kontrol.Dato = reader["datoPåBehandling"].ToString();
                kontrol.Ejertlf = Convert.ToInt32(reader["tlf"]);
                kontrol.Navn = reader["navn"].ToString();
                kontrol.Email = reader["email"].ToString();
                kontrol.Adresse = reader["adresse"].ToString();
                kontrol.PostNr = Convert.ToInt32(reader["postnummer"]);
                kontrol.ByNavn = reader["bynavn"].ToString();
                kontrol.DyrNavn = reader["dyrNavn"].ToString();
                kontrol.AktivInaktiv = Convert.ToChar(reader["aktivInaktiv"]);
                kontrolOplysningers.Add(kontrol);
            }
            reader.Close();
            conn.Close();
            return kontrolOplysningers;
        }
    }
}