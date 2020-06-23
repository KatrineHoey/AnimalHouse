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
    public partial class GUIVisEjer : Form
    {
        // Variabel til erhvervPrivat radiobutten
        char ErhvervPrivate;

        // Variabel til aktivInaktiv radiobutten
        char AktivInaktiv;

        // Kalder controller og liste til denne form.

        Controller c = new Controller();
        List<Behandling> behandlingsliste = new List<Behandling>();
        List<Dyr> dyreliste = new List<Dyr>();
        List<Dyrlæge> dyrlægeliste = new List<Dyrlæge>();
        public GUIVisEjer()
        {
            InitializeComponent();
        }

        // Henter listen med dyrlæger og indlæser dem i combobox lægevalg og udførtaf.
        private void GUIVisEjer_Load(object sender, EventArgs e)
        {// Katrine
            dyrlægeliste = c.HentLægeListe();
            foreach (Dyrlæge l in dyrlægeliste)
            {
                comboBoxLægeValg.Items.Add(l.Navn);
                comboBoxUdførtAf.Items.Add(l.Navn);
            }
        }
      
        // Brugeren vælger at ejeren er privatkunde
        private void radioButtonPrivat_CheckedChanged(object sender, EventArgs e)
        {// Line
            ErhvervPrivate = 'p';
        }
        // Brugeren vælger at ejeren er erhvervskunde.
        private void radioButtonErhverv_CheckedChanged(object sender, EventArgs e)
        {// Line
            ErhvervPrivate = 'e';
        }

        // Hvis brugeren er aktiv angives det i radiobutten og gemmes som en char a i databasen.
        private void radioButtonAktiv_CheckedChanged(object sender, EventArgs e)
        {// Line
            AktivInaktiv = 'a';
        }
        // Hvis brugeren er inaktiv angives det i radiobutten og gemmes som en char i i databasen.
        private void radioButtonInaktiv_CheckedChanged(object sender, EventArgs e)
        {// Line
            AktivInaktiv = 'i';
        }

        // Hvis ejerens oplysninger ikke er korrekt, Messagebox: Oplysninger om ejeren er ikke indtastet korrekt.
        // Gemmer ejeren eller opdater ejerens oplysninger i databasen.
        private void buttonGem_Click(object sender, EventArgs e)
        {// Line
            if (textBoxEjerNavn.Text == "" || textBoxTelefon.Text == "")
            {
                MessageBox.Show("Oplysninger om ejeren er ikke indtastet korrekt");
            }
            else
            {
                string navn = textBoxEjerNavn.Text;
                string adresse = textBoxAdresse.Text;
                int postnr = Convert.ToInt32(textBoxPostNummer.Text);
                string bynavn = textBoxByNavn.Text;
                int tlf = Convert.ToInt32(textBoxTelefon.Text);
                string email = textBoxMail.Text;
                char erhvervPrivate = ErhvervPrivate;
                char aktivInaktiv = AktivInaktiv;
                c.OpretEjer(navn, tlf, email, adresse, postnr, bynavn, erhvervPrivate, aktivInaktiv);
                MessageBox.Show("Ejer oplysninger er gemt i databasen.");
            }
        }

        // Viser behandliger som er knyttet til et bestemt dyr. 
        private void OpdatereBehandlinglisten()
        {// Ibrahim
                Dyr dd = comboBox2.SelectedItem as Dyr;
                var behandlingsliste = c.VisBehandlinger(dd.ID);
                dataGridView1.DataSource = behandlingsliste;
        }

        // Kræver at der er valgt et dyr fra listen.
        // Gemmer de oplysninger der er valgt og skrevet til behandling i forhold til det valgte dyr og gemmer oplysningerne i databasen. 
        private void buttonGemBehandling_Click(object sender, EventArgs e)
        {// Ibrahim
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Vælg et dyr fra listen");
            }
            else
            {
                string datoPåBehandling = Convert.ToString(CalenderdatoPåBehandling.Value.ToString("yyyy-MM-dd"));
                string behandlingstype = comboBoxBehandlingsType.Text;
                string udførtAf = comboBoxUdførtAf.Text;
                string diagnose = DiagnoseBox.Text;

                //Hent dyreID
                string dyrenavn = comboBox2.Text;
                int dyr = 0;
                foreach (Dyr d in dyreliste)
                {
                    if (d.Navn == dyrenavn)
                    {
                        dyr = d.ID;
                    }
                }
                c.RegistrerBehandling(datoPåBehandling, udførtAf, diagnose, behandlingstype, dyr);
                OpdatereBehandlinglisten();

                MessageBox.Show("Behandlings oplysninger er gemt i databasen.");
                DiagnoseBox.Clear();
            }
        }
        // Knappen søger en ejer frem med tlf nummer. 
        // Hvis der ikke er indtastede et tlfnr. vises messagebox: Indtast telefonnummer på ejeren.
        //Den søgte ejers oplysninger kommer frem i textboxene og ejerens dyr indlæses i combobox
        private void buttonSøg_Click(object sender, EventArgs e)
        {// Line
            if (textBoxFindEjer.Text == "")
            {
                MessageBox.Show("Indtast telefonnummer på ejeren");
            }
            else
            {
                int tlf = Convert.ToInt32(textBoxFindEjer.Text);
                Ejer ejer = c.VisEjer(tlf);
                textBoxEjerNavn.Text = ejer.Navn;
                textBoxAdresse.Text = ejer.Adresse;
                textBoxPostNummer.Text = ejer.PostNr.ToString();
                textBoxByNavn.Text = ejer.ByNavn;
                textBoxTelefon.Text = ejer.Telefon.ToString();
                textBoxMail.Text = ejer.Email;

                if (ejer.ErhvervPrivat == 'p')
                {
                    radioButtonPrivat.Checked = true;
                }
                else
                {
                    radioButtonErhverv.Checked = true;
                }

                if (ejer.AktivInaktiv == 'a')
                {
                    radioButtonAktiv.Checked = true;
                }
                else
                {
                    radioButtonInaktiv.Checked = true;
                }
                IndlæsDyrICombobox();
            }
        }


        // Hvis oplysninger om dyret ikke er indtastet korrekt, Messagebox: "Oplysninger om dyret er ikke indtastet korrekt"
        // Ellers bliver dyrets oplysninger gemt i databasen og knyttet til ejeren via tlfnr.
        // Den valgte dyrlæge bliver tilknyttet til dyret.
        
        private void buttonGemDyr_Click(object sender, EventArgs e)
        {//Katrine
            if (comboBox2.Text == "" || textBoxDyrNavn.Text == "" || textBoxDyreType.Text == "")
            {
                MessageBox.Show("Oplysninger om dyret er ikke indtastet korrekt");
            }
            else
            {
                string navn = textBoxDyrNavn.Text;
                string dyretype = textBoxDyreType.Text;
                int fødselsår = Convert.ToInt32(textBoxFødselsår.Text);
                string køn = comboBoxKøn.Text;
                double vægt = Convert.ToDouble(textBoxVægt.Text);
                string kommentar = richTextBox1.Text;

                //Hent Ejer
                int ejer = Convert.ToInt32(textBoxTelefon.Text);

                //Hent lægeID
                string dyrlægenavn = comboBoxLægeValg.Text;

                int dyrlæge = 0;
                foreach (Dyrlæge d in dyrlægeliste)
                {
                    if (d.Navn == dyrlægenavn)
                    {
                        dyrlæge = d.ID;
                    }
                }

                // Hvis dyr id ikke er udfyldt, betyder det at det er et nyt dyr som bliver gemt i databasen.
                // Ellsers bliver dyrets oplysninger opdateret i databasen.

                if (textBoxDyrID.Text == "")
                {
                    c.TilføjDyr(navn, dyretype, fødselsår, køn, vægt, kommentar, ejer, dyrlæge);
                    MessageBox.Show("Oplysninger om dyr er gemt i databasen.");
                }
                else
                {
                    int id = Convert.ToInt32(textBoxDyrID.Text);
                    c.OpdaterDyr(id, navn, dyretype, fødselsår, køn, vægt, kommentar, ejer, dyrlæge);

                    MessageBox.Show("Dyr er opdateret");
                }
                // Metoden indlæser ejerens dyr i comboboxen igen.
                IndlæsDyrICombobox();
            }
        }

        // Brugeren vælger et dyr i comboboxen og oplysningerne om dyret indsættes i textboxene.
        // Hvis brugeren vælger nyt dyr, er feldterne tomme.
        // Løber dyrlægelisten igennem og viser den dyrlæge der er valgt til det pågældende dyr.
        // I Datagridview bliver en liste med tidliger behandlinger vist.

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {// Katrine
            //Det valgte dyr bliver sat ind  i felterne: 
            Dyr dyr = comboBox2.SelectedItem as Dyr;
            textBoxDyrNavn.Text = dyr.Navn;
            textBoxDyreType.Text = dyr.DyreType;
            textBoxFødselsår.Text = dyr.Fødselsår.ToString();
            comboBoxKøn.Text = dyr.Køn;
            textBoxVægt.Text = dyr.Vægt.ToString();
            textBoxDyrID.Text = dyr.ID.ToString();
            if (dyr.Navn == "Nyt dyr") //Hvis der er valgt nyt dyr, så ryddes felterne. 
            {
                textBoxDyrID.Clear();
                textBoxDyrNavn.Clear();
            }
            foreach (Dyrlæge d in dyrlægeliste) //Dyrets foretrukkede dyrlæge bliver hentet frem. 
            {
                if (dyr.Dyrlæge == d.ID)
                {
                    comboBoxLægeValg.Text = d.Navn;
                }
            }
            richTextBox1.Text = dyr.Kommentar;

            // Datagridview 
            var behandlingsliste = c.VisBehandlinger(dyr.ID); //Dyret jounallinjer hentes frem på skærmen. 
            dataGridView1.DataSource = behandlingsliste;
        }


        // Knappen sletter dyret. Hvis der ikke er noget dyr, kommer en messagebox "Der er ikke noget dyr at slette"
        // ellers kommer der en box om brugeren er sikker på der skal slettes. 
        //Oplysningerne i Textboxene bliver herefter slettet og combobox bliver opdateret. 
        private void buttonSletDyr_Click(object sender, EventArgs e)
        { // Line
            if (textBoxDyrID.Text == "" || textBoxDyrID.Text == "Nyt dyr")
            {
                MessageBox.Show("Der er intet dyr at slette");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at dyret skal slettes?", "Sletning af dyr", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(textBoxDyrID.Text);
                    c.SletDyr(id);
                    MessageBox.Show("Dyret er slettet");

                    // Fjerner oplysninger om dyret fra tekstboksene og indlæser dyrerene i combobox.
                    textBoxDyrNavn.Clear();
                    textBoxDyreType.Clear();
                    textBoxFødselsår.Clear();
                    textBoxVægt.Clear();
                    textBoxDyrID.Clear();
                    richTextBox1.Clear();

                    IndlæsDyrICombobox();
                }
            }
        }

        // Knappen Føre brugeren vidre til Bestil tid formen og indsætter tlfnr. fra ejer over i booking. 
        private void buttonBestilTid_Click(object sender, EventArgs e)
        { //Line
            DialogResult dialogResult = MessageBox.Show("Ikke-gemte ændringer vil ikke blive gemt. Vil du gå tilbage for at gemme?", "Gem ændringer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                GUIBestilTid gbt1 = new GUIBestilTid();
                gbt1.textBoxTelefon.Text = textBoxFindEjer.Text;
                gbt1.Show();
                this.Hide();
            } 
        }
        // Retunere brugeren til forsiden, når vinduet lukkes.
        private void GUIVisEjer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            GUIForside gf1 = new GUIForside();
            gf1.Show();
        }

        // Metoder: 

        // Metoden indlæser ejerens dyr i combobox. 
        private void IndlæsDyrICombobox()
        {// Katrine
            int tlf = Convert.ToInt32(textBoxFindEjer.Text);

            //Nulstiller dyrelisten.
            dyreliste.Clear();
            //Finder de dyr som ejeren har og indsætter dem i combobox.
            dyreliste = c.VisDyr(tlf);
            Dyr d = new Dyr();
            d.Navn = "Nyt dyr";
            dyreliste.Add(d);
            comboBox2.DisplayMember = "navn";
            comboBox2.DataSource = dyreliste;
        }

        // Knapper uden funktion: 

        private void DiagnoseBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label10_Click(object sender, EventArgs e)
        {
        }
        private void groupBoxDyr_Enter(object sender, EventArgs e)
        {
        }
        private void buttonOpdater_Click(object sender, EventArgs e)
        {
        }
        private void comboBoxLægeValg_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void CalenderdatoPåBehandling_ValueChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
