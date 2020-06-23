using BLL;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUIBestilTid : Form
    { // Irfan
        Controller c = new Controller();
        List<Dyrlæge> dyrlægeliste = new List<Dyrlæge>();
        List<Booking> bookings = new List<Booking>();
        List<int> burbookingliste = new List<int>();

        public GUIBestilTid()
        {
            InitializeComponent();
        }

        private void GUIBestilTid_Load(object sender, EventArgs e)
        {
            //Henter lægeliste frem
            dyrlægeliste = c.HentLægeListe();
            comboBox1.DisplayMember = "navn";
            comboBox1.DataSource = dyrlægeliste;

            //Sætter behandlingstype til konsultation
            comboBox2.SelectedIndex = 0;

            //Sætter dyretype til hund
            comboBoxDyreType.SelectedIndex = 0;
            comboBoxDyretype2.SelectedIndex = 0;
        }

        private void GUIBestilTid_FormClosing(object sender, FormClosingEventArgs e)
        { // Irfan
            //Loader forsideGUI'en, når denne GUI lukkes.
            this.Hide();
            GUIForside gf1 = new GUIForside();
            gf1.Show();
        }

        // Knapper med tider for konsultation

        private void buttonK900_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK900.Text; // Skriver K 9:00 i tekstboksen med valgt tid. Bruges ved booking af konsultation.
        }

        private void buttonK930_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK930.Text;
        }

        private void buttonK1000_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1000.Text;
        }

        private void buttonK1030_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1030.Text;
        }

        private void buttonK1100_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1100.Text;
        }

        private void buttonK1130_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1130.Text;
        }

        private void buttonK1200_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1200.Text;
        }

        private void buttonK1230_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1230.Text;
        }

        private void buttonK1300_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1300.Text;
        }

        private void buttonK1330_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1330.Text;
        }

        private void buttonK1400_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1400.Text;
        }

        private void buttonK1430_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonK1430.Text;
        }

        // Knapper med tider for operation

        private void buttonO900_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO900.Text; // Skriver O 9:00 i tekstboksen valgt tid. Bruges ved booking af operation.
        }

        private void buttonO1000_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO1000.Text;
        }

        private void buttonO1100_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO1100.Text;
        }

        private void buttonO1200_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO1200.Text;
        }

        private void buttonO1300_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO1300.Text;
        }

        private void buttonO1400_Click(object sender, EventArgs e)
        {
            textBoxValgtTid.Text = buttonO1400.Text;
        }

        private void buttonGem_Click(object sender, EventArgs e)
        {//Irfan
            
                // Tjekker om der er indtastet telefonnummer, tid og burnummer, hvis "book bur" er checket af.
                if (textBoxTelefon.Text == "")
                {
                    MessageBox.Show("Indtast telefonnummer");
                    goto her;
                }

                // Tjekker om ejeren er eksisterende i systemet.
                Ejer checkEjer = c.VisEjer(Convert.ToInt32(textBoxTelefon.Text));
                if (checkEjer.Telefon == 0)
                {
                    MessageBox.Show("Telefonnummer er IKKE gyldigt");
                }

                // Tjekker om der er indtastet telefonnummer, tid og burnummer, hvis "book bur" er checket af.
                else if (textBoxTelefon.Text == "")
                {
                    MessageBox.Show("Indtast telefonnummer");
                }
                else if (textBoxValgtTid.Text == "")
                {
                    MessageBox.Show("Vælg en tid");
                }
                else if (checkBoxBookBur.Checked == true && comboBoxBurnummerOpretTid.Text == "")
                {
                    MessageBox.Show("Vælg burnummer");
                }
                else
                {
                    string kommentar = richTextBox1.Text;
                    string dato = Convert.ToString(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    int ejerTlf = int.Parse(textBoxTelefon.Text);
                    Dyrlæge dyrlæge = comboBox1.SelectedItem as Dyrlæge;
                    int dyrlægeID = dyrlæge.ID;
                    string behandlingsType = comboBox2.Text;
                    string klokkeslæt = textBoxValgtTid.Text;

                    SøgBookedeTiderFrem();
                    bool reload = ReloadBookedeTider();
                    if (reload == false)
                    {
                        MessageBox.Show("Denne tid kan ikke bookes");
                        goto her;
                    }

                    // Gemmer en tidsbestilling i databasen.
                    string lykkes = c.BestilTid(kommentar, dato, klokkeslæt, ejerTlf, dyrlægeID, behandlingsType);

                    // Booking af bur sammen med tid, som lige er blevet oprettet.
                    if (checkBoxBookBur.Checked == true)
                    {
                        int bookingID = c.HentNyesteBookingNr(); // Henter max-værdien for booking-ID, dermed det nyeste ID.

                        BookBur(dateTimePicker1, dateTimePickerSlutdatoOpretTid, comboBoxBurnummerOpretTid, bookingID); //Gemmer buret
                    }

                 MessageBox.Show(lykkes);

                    richTextBox1.Clear();
                    textBoxTelefon.Clear();

                }
            
         her:;

            Nulstilknapper();
            SøgBookedeTiderFrem();
        }


        // Indtast kun tal i tekstbox til telefonnummer (Den under kommentar)
        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        { // Irfan
            IndtastKunTal(e);
        }

        private void button_sletTid_Click(object sender, EventArgs e)
        { // Irfan

            // Hvis et ID på en booking ikke er skrevet i tekstboks til sletning af ID.
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Vælg id nummer på booking");
            }
            else
            {
                // MessageBox, der sørger for at brugeren bekræfter sit tryk på "Slet tid"
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette tid", "Slet tid", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (textBoxID.Text != "")
                    {
                        int Id = Convert.ToInt32(textBoxID.Text);
                        c.SletTid(Id); // Sletter en tid udfra det indtastede ID i tekstboksen.

                        MessageBox.Show("Tiden er nu slettet");
                    }
                }
            }

        }

        // Indtast kun tal i textbox (Den ved slet tid)
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        { // Irfan
            IndtastKunTal(e);
        }
        // Sletter de oplysninger i txt telefon og kommentar.
        private void buttonAnnullerTid_Click(object sender, EventArgs e)
        { //Irfan
            textBoxTelefon.Clear();
            richTextBox1.Clear();
        }
        // Kalender under bestil tid. Først gøres alle klokkeslet knapper aktive.
        // Henter de tider som er bookede og deaktiver de knapper hvor der ikke kan bookes tid.
        // Søger ledige bur frem udfra valgte kriterier.
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { // Irfan
            Nulstilknapper();
            SøgBookedeTiderFrem();
            SøgLedigeBure(dateTimePicker1, dateTimePickerSlutdatoOpretTid, comboBoxDyreType, comboBoxBurnummerOpretTid, label11, buttonGem);
        }
        
        // viser bookinger søgt frem via ejer telefonnummer.
        private void button_SøgDataGridView_Click(object sender, EventArgs e)
        { // Irfan

            // Hvis telefonummeret ikke er udfyldt, så fremkommer MessageBox.
            if (textBoxSøgtlf.Text == "")
            {
                MessageBox.Show("Udfyld telefonnummer.");
            }
            else
            {
                int ejerTlf = Convert.ToInt32(textBoxSøgtlf.Text);

                DataTable bookinglisteDato = c.BookingBBDataTable(ejerTlf, 2); // Søger både operation og konsultation frem.

                // Booking indlæses i datagridview sammen med burbookinger.
                dataGridView1.DataSource = bookinglisteDato;
                dataGridView1.ReadOnly = true;

            }

        }
        // Der kan kun skrives tal i textbox bookingId
        private void textBoxOperationID_KeyPress(object sender, KeyPressEventArgs e)
        { // Irfan
            IndtastKunTal(e);
        }
        // viser bookinger søgt frem via ejer telefonnummer.
        private void buttonKunOperation_Click(object sender, EventArgs e)
        {// Irfan
            if (textBoxSøgtlf.Text == "")
            {
                MessageBox.Show("Udfyld telefonnummer.");
            }
            else
            {
                int ejerTlf = Convert.ToInt32(textBoxSøgtlf.Text);

                // Kun operationsbookinger indlæses i datagridview. 1-tallet sætter variablen søg til at der kun søges operationer.
                DataTable bookingliste = c.BookingBBDataTable(ejerTlf, 1);

                dataGridView1.DataSource = bookingliste; // Kun operationer indlæses i datagridview.
            }

        }
        // Knappen Bookbur. Gemmer booking af bur, for en bestilling hvor oprerationen er bestilt tidliger uden bur er booket.
        private void button1_Click(object sender, EventArgs e)
        { // Irfan

            if (textBoxOperationID.Text == "")
            {
                MessageBox.Show("Ikke alle felter er udfyldt.");
            }
            else
            {
                int operationID = int.Parse(textBoxOperationID.Text);
                BookBur(dateTimePickerStart, dateTimePickerSlut, comboBoxBur, operationID); //Gemmer buret
            }
        }
        // Søger ledige bur frem til den valgte dyretype udfra de indtastede/valgte værdier
        private void comboBoxDyreType_SelectedIndexChanged_1(object sender, EventArgs e)
        {// Irfan
            if (comboBox2.Text == "Operation")
            {
                SøgLedigeBure(dateTimePicker1, dateTimePickerSlutdatoOpretTid, comboBoxDyreType, comboBoxBurnummerOpretTid, label11, buttonGem);
            }
           
        }

        // Groupbox til bookbur deaktiveres ved valg af konsultation. 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { // Irfan
            // Bur kan ikke bookes til en konsultation.
            if (comboBox2.Text == "Konsultation")
            {
                // Deaktiver operations tidsknapper
                groupBoxBookBurVedNyTid.Visible = false;
                buttonO900.Visible = false;
                buttonO1000.Visible = false;
                buttonO1100.Visible = false;
                buttonO1200.Visible = false;
                buttonO1300.Visible = false;
                buttonO1400.Visible = false;

                // Aktiver konsultations tidsknapper.
                buttonK900.Visible = true;
                buttonK930.Visible = true;
                buttonK1000.Visible = true;
                buttonK1030.Visible = true;
                buttonK1100.Visible = true;
                buttonK1130.Visible = true;
                buttonK1200.Visible = true;
                buttonK1230.Visible = true;
                buttonK1300.Visible = true;
                buttonK1330.Visible = true;
                buttonK1400.Visible = true;
                buttonK1430.Visible = true;
            }

            // Burbooking til operation. Der søges på ledige bure.
            if (comboBox2.Text == "Operation")
            {
                // Aktiver groupbox med book bur, fordi operation er valgt og søger ledige bur frem.
                groupBoxBookBurVedNyTid.Visible = true;
                SøgLedigeBure(dateTimePicker1, dateTimePickerSlutdatoOpretTid, comboBoxDyreType, comboBoxBurnummerOpretTid, label11, buttonGem);
                // Deaktiver konsultations tidsknapper.
                buttonK900.Visible = false;
                buttonK930.Visible = false;
                buttonK1000.Visible = false;
                buttonK1030.Visible = false;
                buttonK1100.Visible = false;
                buttonK1130.Visible = false;
                buttonK1200.Visible = false;
                buttonK1230.Visible = false;
                buttonK1300.Visible = false;
                buttonK1330.Visible = false;
                buttonK1400.Visible = false;
                buttonK1430.Visible = false;

                // Aktiver operations tidsknapper.
                buttonO900.Visible = true;
                buttonO1000.Visible = true;
                buttonO1100.Visible = true;
                buttonO1200.Visible = true;
                buttonO1300.Visible = true;
                buttonO1400.Visible = true;
            }
        }

        // Hvis der skiftes læge i comboboxen, indlæses der tider for den nye læge. (combobox1 = Læge)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nulstilknapper();
            SøgBookedeTiderFrem();
        }

        //Under startdato. Søger ledige bur udfra valgte oplysninger
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        { // Irfan
            SøgLedigeBure(dateTimePickerStart, dateTimePickerSlut, comboBoxDyretype2, comboBoxBur, label9, button1);
        }
        //Under slutdato. Søger ledige bur udfra valgte oplysninger
        private void dateTimePickerSlut_ValueChanged(object sender, EventArgs e)
        { // Irfan
            SøgLedigeBure(dateTimePickerStart, dateTimePickerSlut, comboBoxDyretype2, comboBoxBur, label9, button1);
        }
        // Ser om der er makeret i checkbox book bur og valgt operation. Hvis true kommer book bur frem
        private void checkBoxBookBur_CheckedChanged(object sender, EventArgs e)
        { // Irfan
            if (checkBoxBookBur.Checked == true)
            {
                if (comboBox2.Text == "Operation")
                {
                    groupBoxBookBurVedNyTid.Visible = true;
                }
                else
                // Hvis behandlingstypen ikke er sat til operation, kan der ikke bookes bur.
                {
                    MessageBox.Show("Behandlingstypen er ikke sat til operation.");
                    checkBoxBookBur.Checked = false;
                }
            }
            // checkboxen "Book bur" skal være checket af, hvis der skal kunne bookes bur.
            if (checkBoxBookBur.Checked == false)
            {
                groupBoxBookBurVedNyTid.Visible = false;
            }
        }
        // Opdatere ledige bur når slutdato ændres.
        private void dateTimePickerSlutdatoOpretTid_ValueChanged(object sender, EventArgs e)
        { //Irfan
            SøgLedigeBure(dateTimePicker1, dateTimePickerSlutdatoOpretTid, comboBoxDyreType, comboBoxBurnummerOpretTid, label11, buttonGem);
        }
        // Opdatere ledige tid når dyre type ændres.
        private void comboBoxDyretype2_SelectedIndexChanged(object sender, EventArgs e)
        { //Irfan
            SøgLedigeBure(dateTimePickerStart, dateTimePickerSlut, comboBoxDyretype2, comboBoxBur, label9, button1);
        }

        // Metoder
        // søger de bookede tider frem for at kunne deaktivere tidsknapperne.
        private void SøgBookedeTiderFrem()
        { // Irfan
            string dato = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Dyrlæge dyrlæge = comboBox1.SelectedItem as Dyrlæge;
            int dyrlægeID = dyrlæge.ID;

            //Henter bookede tider frem.
            List<Booking> tider = c.HentBookedeTider(dato, dyrlægeID);

            foreach (Booking booking in tider)
            {//Finder ud af hvilke knapper som ikke må kunne vælges, fordi der allerede er booket her. 
                string tid = booking.Klokkeslæt; 
                switch (tid)
                {
                    case "K 09:00":
                        buttonK900.Enabled = false;
                        buttonO900.Enabled = false;
                        break;

                    case "O 09:00":
                        buttonK900.Enabled = false;
                        buttonO900.Enabled = false;
                        buttonK930.Enabled = false;
                        break;

                    case "K 09:30":
                        buttonK930.Enabled = false;
                        buttonO900.Enabled = false;
                        break;

                    case "K 10:00":
                        buttonK1000.Enabled = false;
                        buttonO1000.Enabled = false;
                        break;

                    case "O 10:00":
                        buttonK1000.Enabled = false;
                        buttonO1000.Enabled = false;
                        buttonK1030.Enabled = false;
                        break;

                    case "K 10:30":
                        buttonK1030.Enabled = false;
                        buttonO1000.Enabled = false;
                        break;

                    case "K 11:00":
                        buttonK1100.Enabled = false;
                        buttonO1100.Enabled = false;
                        break;

                    case "O 11:00":
                        buttonK1100.Enabled = false;
                        buttonO1100.Enabled = false;
                        buttonK1130.Enabled = false;
                        break;

                    case "K 11:30":
                        buttonK1130.Enabled = false;
                        buttonO1100.Enabled = false;
                        break;

                    case "K 12:00":
                        buttonK1200.Enabled = false;
                        buttonO1200.Enabled = false;
                        break;

                    case "O 12:00":
                        buttonK1200.Enabled = false;
                        buttonO1200.Enabled = false;
                        buttonK1230.Enabled = false;
                        break;

                    case "K 12:30":
                        buttonK1230.Enabled = false;
                        buttonO1200.Enabled = false;
                        break;

                    case "K 13:00":
                        buttonK1300.Enabled = false;
                        buttonO1300.Enabled = false;
                        break;

                    case "O 13:00":
                        buttonK1300.Enabled = false;
                        buttonO1300.Enabled = false;
                        buttonK1330.Enabled = false;
                        break;

                    case "K 13:30":
                        buttonK1330.Enabled = false;
                        buttonO1300.Enabled = false;
                        break;

                    case "K 14:00":
                        buttonK1400.Enabled = false;
                        buttonO1400.Enabled = false;
                        break;

                    case "O 14:00":
                        buttonK1400.Enabled = false;
                        buttonO1400.Enabled = false;
                        buttonK1430.Enabled = false;
                        break;

                    case "K 14:30":
                        buttonK1430.Enabled = false;
                        buttonO1400.Enabled = false;
                        break;

                    default:
                        break;
                }
            }
        }
        // Metoden aktiver, deaktiveret knapper.  
        private void Nulstilknapper()
        { // Irfan
            buttonK900.Enabled = true;
            buttonO900.Enabled = true;
            buttonK930.Enabled = true;

            buttonK1000.Enabled = true;
            buttonO1000.Enabled = true;
            buttonK1030.Enabled = true;

            buttonK1100.Enabled = true;
            buttonO1100.Enabled = true;
            buttonK1130.Enabled = true;

            buttonK1200.Enabled = true;
            buttonO1200.Enabled = true;
            buttonK1230.Enabled = true;

            buttonK1300.Enabled = true;
            buttonO1300.Enabled = true;
            buttonK1330.Enabled = true;

            buttonK1400.Enabled = true;
            buttonO1400.Enabled = true;
            buttonK1430.Enabled = true;
        }

        // Metode til at booke bur, bur kan max bookes i 4 dage.
        public void BookBur(DateTimePicker dtpStart, DateTimePicker dtpSlut, ComboBox cbBurID, int operationsID)
        {// Irfan
            // Start og slut datoer i bookbur konvateres.
            string startDato = dtpStart.Value.ToString("yyyy-MM-dd");
            DateTime startDatoDT = DateTime.Parse(startDato);
            string slutDato = dtpSlut.Value.ToString("yyyy-MM-dd");
            DateTime slutDatoDT = DateTime.Parse(slutDato);

            // Definition af variable for anden- og tredjedagen i et interval på fire dage fra start- til slutdato.(ser om bur er ledig på 2. og 3. dag)
            string datoDag2 = (startDatoDT.AddDays(1)).ToString("yyyy-MM-dd");
            string datoDag3 = (startDatoDT.AddDays(2)).ToString("yyyy-MM-dd");

            DateTime datoDag2DT = DateTime.Parse(datoDag2);
            DateTime datoDag3DT = DateTime.Parse(datoDag3);

            // Forskel mellem start- og slutdato beregnes.
            double forskel = (slutDatoDT - startDatoDT).TotalDays;

            // Fejlmeddelelse, hvis forskellen mellem start- og slutdato er over 4.
            if (forskel > 4)
            {
                MessageBox.Show("Et bur kan højst bookes for fire dage ad gangen.");
            }
            else if (comboBoxBur.Text == "")
            {
                MessageBox.Show("Ikke alle felter er udfyldt.");
            }
            else
            {
                // Anden og tredjedag sættes til default-værdier, hvis forskellen mellem start- og slutdato er mindre end 4.
                if (startDato == slutDato)
                {
                    datoDag2 = "1111-11-11";
                    datoDag3 = "1111-11-11";
                }
                if (datoDag2DT == slutDatoDT)
                {
                    datoDag2 = "2222-11-11";
                    datoDag3 = "2222-11-11";
                }
                if (datoDag3DT == slutDatoDT)
                {
                    datoDag3 = "2222-11-11";
                }

                int burID = int.Parse(cbBurID.Text);

                c.BookBur(startDato, datoDag2, datoDag3, slutDato, burID, operationsID); // Booking af bur udføres til eksisterende operation.
                MessageBox.Show("Booking af bur er gemt i databasen");

            }
        }
        // Laver først en clear. 
        //Metoden henter de ledige bur og burid vises i combobox.
        private void SøgLedigeBure(DateTimePicker startDtp, DateTimePicker slutDtp, ComboBox dyr, ComboBox burNr, Label maks4Dage, Button Gem)
        { // Irfan
            burNr.Items.Clear();


            string startDato = startDtp.Value.ToString("yyyy-MM-dd");
            DateTime startDatoDT = DateTime.Parse(startDato);
            string slutDato = slutDtp.Value.ToString("yyyy-MM-dd");
            DateTime slutDatoDT = DateTime.Parse(slutDato);

            // Definition af variable for anden- og tredjedag i 4-dages interval.
            string datoDag2 = (startDatoDT.AddDays(1)).ToString("yyyy-MM-dd");
            string datoDag3 = (startDatoDT.AddDays(2)).ToString("yyyy-MM-dd");

            // Beregning af forskel mellem start- og slutdato.
            double forskel = (slutDatoDT - startDatoDT).TotalDays;

            // Rød advarselslabel fremkommer, hvis man prøver at booke label i længere end fire dage.
            if (forskel > 3)
            {
                maks4Dage.Visible = true;
                Gem.Enabled = false;
            }
            else
            {
                maks4Dage.Visible = false;
                Gem.Enabled = true;
            }

            string dyreType = dyr.Text;

            // Indsætter bur-id på ledige bure i combobox.
            burbookingliste = c.HentLedigeBure(startDato, datoDag2, datoDag3, slutDato, dyreType); 
            foreach (int bb in burbookingliste)
            {
                burNr.Items.Add(bb);
            }
            if (burbookingliste.Count >= 1)
            {
                burNr.SelectedIndex = 0;
            }  
        }
        // Tjekker for om der er kommet nye bookinger af tider, imens der er forsøgt at booke en tid. 
        //Hvis en anden bruger har nået at booke tiden vises en fejlbesked.
        private bool ReloadBookedeTider()
        { // Irfan
            if (buttonK900.Text == textBoxValgtTid.Text)
            {
                if (buttonK900.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK930.Text == textBoxValgtTid.Text)
            {
                if (buttonK930.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1000.Text == textBoxValgtTid.Text)
            {
                if (buttonK1000.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1030.Text == textBoxValgtTid.Text)
            {
                if (buttonK1030.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1100.Text == textBoxValgtTid.Text)
            {
                if (buttonK1100.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1130.Text == textBoxValgtTid.Text)
            {
                if (buttonK1130.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1200.Text == textBoxValgtTid.Text)
            {
                if (buttonK1200.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1230.Text == textBoxValgtTid.Text)
            {
                if (buttonK1230.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1300.Text == textBoxValgtTid.Text)
            {
                if (buttonK1300.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1330.Text == textBoxValgtTid.Text)
            {
                if (buttonK1330.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1400.Text == textBoxValgtTid.Text)
            {
                if (buttonK1400.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonK1430.Text == textBoxValgtTid.Text)
            {
                if (buttonK1430.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonO1000.Text == textBoxValgtTid.Text)
            {
                if (buttonO1000.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonO1100.Text == textBoxValgtTid.Text)
            {
                if (buttonO1100.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonO1200.Text == textBoxValgtTid.Text)
            {
                if (buttonO1200.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonO1300.Text == textBoxValgtTid.Text)
            {
                if (buttonO1300.Enabled == false)
                {
                    return false;
                }
            }
            else if (buttonO1400.Text == textBoxValgtTid.Text)
            {
                if (buttonO1400.Enabled == false)
                {
                    return false;
                }
            }

            return true;
        }
        // Metode til at sikre der kun kan indtastes tal i textboxe
        public void IndtastKunTal(KeyPressEventArgs e)
        {// Irfan
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8) // 8 representer backspace. dsv. man kan slette i boxen.
            {
                e.Handled = true;
            }
        }

        // Knapper uden funktion
        private void comboBoxBur_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxBurnummerOpretTid_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label15_Click(object sender, EventArgs e)
        {
        }
        private void checkBoxKonsultation_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBoxOperation_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBoxBookBur_Enter(object sender, EventArgs e)
        {
        }
        private void buttonSøgBur_Click(object sender, EventArgs e)
        {
        }
        private void comboBoxDyreType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void textBoxBurID_TextChanged(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
