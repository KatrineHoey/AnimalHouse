using BLL;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class GUIFaktura : Form
    {
        Controller c = new Controller();
        List<Faktura> fakturaliste = new List<Faktura>();
        decimal PrisIAlt = 0;
        public GUIFaktura()
        {
            InitializeComponent();
        }

        private void GUIFaktura_Load(object sender, EventArgs e)
        { //Katrine
            //Hent varertyper: 
            List<TypeSalg> typer = c.HentTypeSalg();
            comboBoxBehandlingstype.DisplayMember = "beskrivelse";
            comboBoxBehandlingstype.DataSource = typer;
            
            //Radioknappen "ikke betalt" er defeault checked:
            radioButtonErIkkeBetalt.Checked = true;

            //Lav refresh knap:
            this.button1.Image = (Image)(new Bitmap(Properties.Resources.refresh, new Size(32, 32)));

            //Hent alle faktura:
            RefreshFaktura();
            dataGridViewAlleFaktura.ReadOnly = true;

            //Gøre datagridview ændringsbar. 
            dataGridViewFakturaLinjer.Columns.Add("SalgID", "SalgID");
            dataGridViewFakturaLinjer.Columns.Add("SalgBeskrivelse", "Beskrivelse");
            dataGridViewFakturaLinjer.Columns.Add("Antal", "Antal");
            dataGridViewFakturaLinjer.Columns.Add("Pris", "Stk. pris");
            dataGridViewFakturaLinjer.Columns.Add("BeregnetPris", "Pris");

            //Hent rabatmuligheder.
            comboBoxRabat.Items.Add("10");
            comboBoxRabat.Items.Add("25");
            comboBoxRabat.Items.Add("50");
            comboBoxRabat.Items.Add("75");
        }

        private void buttonGem_Click(object sender, EventArgs e)
        { //Katrine
            
            if (textBoxtelefonEjer.Text == "")  //Check om tlf feltet er udfyldt. 
            {
                MessageBox.Show("Udfyld telefonnummer");
                goto her;
            }

            Ejer checkEjer = c.VisEjer(Convert.ToInt32(textBoxtelefonEjer.Text));
            if (checkEjer.Telefon == 0)  //Check om tlf nr. er gyldigt.
            {
                MessageBox.Show("Telefonnummer er IKKE gyldigt");
            }
            else 
            {
                if (textBoxFakturanummer.Text == "") //Gem data
                {
                    string dato = dateTimePicker1.Text;
                    int ejer = Convert.ToInt32(textBoxtelefonEjer.Text);
                    bool betalt = radioButtonErBetalt.Checked;

                    //Kald controller metode til at gemme faktura:
                    c.GemFaktura(dato, ejer, betalt);

                    //Hent Fakturanummer fra databasen til textboxfelt:
                    RefreshFaktura();
                    Faktura f = fakturaliste[0]; //Finder den nyeste faktura - den med det højeste IDnummer
                    textBoxFakturanummer.Text = f.ID.ToString();

                }
                else //Opdater data
                {
                    int tæl = 0;
                    //Check om fakturanummer er gyldigt: 
                    foreach (Faktura f in fakturaliste)
                    {
                        if (f.ID == Convert.ToInt32(textBoxFakturanummer.Text))
                        {
                            //Opdatere faktura 
                            int faktura = Convert.ToInt32(textBoxFakturanummer.Text);
                            string dato = dateTimePicker1.Text;
                            int ejer = Convert.ToInt32(textBoxtelefonEjer.Text);
                            bool betalt = radioButtonErBetalt.Checked;
                            c.OpdaterFaktura(faktura, dato, ejer, betalt);

                            //Slet salgslinjer
                            c.SletSalgslinjer(faktura);
                            break;
                        }
                        tæl = tæl + 1;
                    }
                    if (tæl == fakturaliste.Count) //tæller om loopet når hele listen igennem.
                    {
                        MessageBox.Show("Fakturanummeret er IKKE gyldigt!");
                    }
                }

                //Gem salgslinjer i databasen - både ved gem og opdater:
                int fakturaID = Convert.ToInt32(textBoxFakturanummer.Text);

                for (int i = 0; i < dataGridViewFakturaLinjer.Rows.Count - 1; i++)
                {
                    int antal = Convert.ToInt32(dataGridViewFakturaLinjer.Rows[i].Cells["Antal"].Value);
                    decimal pris = Convert.ToDecimal(dataGridViewFakturaLinjer.Rows[i].Cells["Pris"].Value, CultureInfo.InvariantCulture);
                    int salgID = Convert.ToInt32(dataGridViewFakturaLinjer.Rows[i].Cells["SalgID"].Value);

                    c.GemSalgslinje(antal, salgID, fakturaID, pris);
                }
                MessageBox.Show("Data gemt");
            }

        her:;
 
        }

        private void buttonTilføjTilFaktura_Click(object sender, EventArgs e) //Tilføj salgslinje til faktura
        { //Katrine
            if (numericUpDownAntal.Value != 0 && textBoxPris.Text != "" && comboBoxVarer.SelectedItem as Salg != null) //Tjekker om alle felter er udfyldt.
            {
                int antal = Convert.ToInt32(Math.Round(numericUpDownAntal.Value));
                decimal pris = Convert.ToDecimal(textBoxPris.Text, CultureInfo.InvariantCulture);
                if (comboBoxRabat.SelectedItem != null) //Tjekker om der skal gives rabat. 
                {
                    int rabat = Convert.ToInt32(comboBoxRabat.SelectedItem);
                    decimal rabatIKr = (pris / 100 * rabat);
                    pris = pris - rabatIKr;
                }
              
                Salg salg = comboBoxVarer.SelectedItem as Salg;

                //Indsætte en salgslinje i datagridview.
                dataGridViewFakturaLinjer.Rows.Add(salg.ID, salg.Beskrivelse, antal, pris, pris * antal);

                PrisIAlt = PrisIAlt + pris; //Opdatere pris i alt. 
                labelIAltPris.Text = PrisIAlt.ToString();
                
                //Antal sætter til 1 igen. 
                numericUpDownAntal.Value = 1;

                //Opdatere antal varer på lager i databasen. 
                char kommando = '-';
                c.OpdatereAntalVarerPåLager(antal, salg.ID, kommando);

            }
            else
            {
                MessageBox.Show("Kunne ikke indsætte varen");
            }
        }

        private void buttonSletLinje_Click(object sender, EventArgs e) //Sletter en salgslinje fra faktura.
        { //Katrine
            foreach (DataGridViewRow d in dataGridViewFakturaLinjer.SelectedRows)
            {
                //Tilretter i alt prisen
                decimal pris = Convert.ToDecimal(dataGridViewFakturaLinjer.Rows[0].Cells["Pris"].Value);
                PrisIAlt = PrisIAlt - pris;
                labelIAltPris.Text = PrisIAlt.ToString();

                //Opdatere antal varer på lager i databasen. 
                int antal = Convert.ToInt32(dataGridViewFakturaLinjer.Rows[0].Cells["Antal"].Value);
                int salgID = Convert.ToInt32(dataGridViewFakturaLinjer.Rows[0].Cells["SalgID"].Value);
                char kommando = '+';
                c.OpdatereAntalVarerPåLager(antal, salgID, kommando);

                //fjerner linjen
                dataGridViewFakturaLinjer.Rows.Remove(d);
            }
        }

        private void comboBoxBehandlingstype_SelectedIndexChanged(object sender, EventArgs e) //Vælger en varetype. 
        { //Katrine
            TypeSalg typeSalg = comboBoxBehandlingstype.SelectedItem as TypeSalg;
            List<Salg> salgsliste = c.HentSalg(typeSalg.ID); //Henter varer udfra angivet varetype. 
            comboBoxVarer.DisplayMember = "beskrivelse";
            comboBoxVarer.DataSource = salgsliste;
        }

        private void comboBoxVarer_SelectedIndexChanged(object sender, EventArgs e) //Vælger en vare
        {//Katrine
            Salg salg = comboBoxVarer.SelectedItem as Salg;
            textBoxPris.Text = salg.Pris.ToString(CultureInfo.InvariantCulture); //Indsætter varens pris.
            numericUpDownAntal.Value = 1; //sætter antal til 1.

            //Viser antal varer på lager på skærmen
            if (comboBoxBehandlingstype.Text == "Medicin" || comboBoxBehandlingstype.Text == "Vare")
            {
                label7.Text = salg.Antal.ToString() + "stk.";
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void radioButtonAlle_CheckedChanged(object sender, EventArgs e) //Viser alle fakturaer
        {//Katrine
            dataGridViewAlleFaktura.DataSource = fakturaliste; 
        }

        private void radioButtonIkkeBetalt_CheckedChanged(object sender, EventArgs e) //Viser kun 'ikke betalte' fakturaer
        {//Katrine
            List<Faktura> fakturalisteIkkeBetalt = new List<Faktura>();
            foreach (Faktura f in fakturaliste)
            {
                if (f.Betalt == false)
                {
                    fakturalisteIkkeBetalt.Add(f);
                }
            }
            dataGridViewAlleFaktura.DataSource = fakturalisteIkkeBetalt;
        }

        private void radioButtonBetalt_CheckedChanged(object sender, EventArgs e) //Viser kun betalte fakturaer.
        {//Katrine
            List<Faktura> fakturalisteBetalt = new List<Faktura>();
            foreach (Faktura f in fakturaliste)
            {
                if (f.Betalt == true)
                {
                    fakturalisteBetalt.Add(f);
                }
            }
            dataGridViewAlleFaktura.DataSource = fakturalisteBetalt;
        }

        private void buttonSøgEjer_Click(object sender, EventArgs e) //Visser de faktura som er tilknyttet det søgte tlf. nummer. 
        {//Katrine
            if (textBoxTlf.Text != "")
            {
                List<Faktura> fakturalisteTelefon = new List<Faktura>();
                foreach (Faktura f in fakturaliste)
                {
                    if (f.EjerTlf == Convert.ToInt32(textBoxTlf.Text))
                    {
                        fakturalisteTelefon.Add(f);
                    }
                }
                dataGridViewAlleFaktura.DataSource = fakturalisteTelefon;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Refresh-knap
        {//Katrine
            RefreshFaktura();
        }

        private void buttonSletFaktura_Click(object sender, EventArgs e) //Sletter en faktura. 
        {//Katrine
            DialogResult dialogResult = MessageBox.Show("Er du sikker at du vil slet denne faktura", "Slet faktura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBoxFakturanummer.Text != "") //Tjekker om der står et fakturanummer. 
                {
                    int fakturaId = Convert.ToInt32(textBoxFakturanummer.Text);
                    c.SletFaktura(fakturaId); //Sletter fakturaen. 

                    RefreshFaktura(); //Opdaterer datagridview. 

                    MessageBox.Show("Fakturen er nu slettet");
                }

                //Nulstiller felterne
                dataGridViewFakturaLinjer.Rows.Clear();
                textBoxFakturanummer.Clear();
                textBoxtelefonEjer.Text = "1";
                textBoxNavn.Clear();
            }
        }

        private void buttonSøg_Click(object sender, EventArgs e) //Søger efter en faktura
        {//Katrine
            SøgSalgslinjerFraFaktura(); //Indsætter fakturalinjer der er tilknyttet det søgte fakturanummer. 
        }

        private void dataGridViewAlleFaktura_CellContentClick(object sender, DataGridViewCellEventArgs e) //En valgt faktura fra højre datagridview, vises på det venstre datagridview. 
        {//Katrine
            if (dataGridViewAlleFaktura.SelectedRows.Count > 0) // Tjekker om der er valgt mindst 1 række.  
            {
                //Opdatere felterne på venstre side af skærmbilledet. 
                textBoxFakturanummer.Text = dataGridViewAlleFaktura.SelectedRows[0].Cells[0].Value + string.Empty;
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewAlleFaktura.SelectedRows[0].Cells[1].Value);
                textBoxtelefonEjer.Text = dataGridViewAlleFaktura.SelectedRows[0].Cells[2].Value + string.Empty;
                int tlf = Convert.ToInt32(textBoxtelefonEjer.Text);
                Ejer ejer = c.VisEjer(tlf); //Finder ejernavnet. 
                textBoxNavn.Text = ejer.Navn;
                bool betalt = Convert.ToBoolean(dataGridViewAlleFaktura.SelectedRows[0].Cells[3].Value);
                if (betalt == true)
                {
                    radioButtonErBetalt.Checked = true;
                }
                else
                {
                    radioButtonErIkkeBetalt.Checked = true;
                }
                SøgSalgslinjerFraFaktura(); //Indsætter fakturalinjer 
            }
        }

        private void GUIFaktura_FormClosing_1(object sender, FormClosingEventArgs e) //Når siden lukkes, så åbnes forsiden.
        { //Katrine
            this.Hide();
            GUIForside guiForside = new GUIForside();
            guiForside.Show();
        }

        private void textBoxFakturanummer_KeyPress(object sender, KeyPressEventArgs e)
        { //Katrine
            IndTastKunTal(e);
        }

        private void textBoxPris_KeyPress(object sender, KeyPressEventArgs e)
        { //Katrine
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //Feltet må kun modtage tal og punktum. 
            {
                e.Handled = true;
            }
        }

        private void textBoxtelefonEjer_KeyPress(object sender, KeyPressEventArgs e) 
        { //Katrine 
            IndTastKunTal(e);
        }

        private void textBoxTlf_KeyPress(object sender, KeyPressEventArgs e)
        { //Katrine
            IndTastKunTal(e);
        }

      
        // Kun heltal i antal feltet. Og backspace er muligt. 
        private void numericUpDownAntal_KeyPress(object sender, KeyPressEventArgs e) 
        { //Irfan og Line
            if (e.KeyChar != 8 && e.KeyChar < 48 || e.KeyChar > 57) //Der må ikke indtastet komma i numericUpDown.
            {
                e.Handled = true;
            }
        }


        // Metoder
        private void SøgSalgslinjerFraFaktura()
        {//Katrine
            PrisIAlt = 0;
            if (textBoxFakturanummer.Text != "")
            {
                int fakturaID = Convert.ToInt32(textBoxFakturanummer.Text);
                var salgslinjer = c.HentSalgslinjerFraFaktura(fakturaID); //Henter salgslinjer
                dataGridViewFakturaLinjer.Rows.Clear();
                foreach (var salgslinje in salgslinjer) //Salgslinjer indsættes i datagridview. 
                {
                    dataGridViewFakturaLinjer.Rows.Add(salgslinje.SalgID, salgslinje.SalgsBeskrivelse, salgslinje.Antal, salgslinje.Pris, salgslinje.Pris * salgslinje.Antal);
                    PrisIAlt = PrisIAlt + (salgslinje.Pris * salgslinje.Antal);
                }
            }
            else
            {
                dataGridViewFakturaLinjer.Rows.Clear();
            }
            labelIAltPris.Text = PrisIAlt.ToString();
        }

        private void RefreshFaktura() //Henter på ny alle faktura fra databasen. 
        {//Katrine
            fakturaliste = c.HentAlleFaktura();
            dataGridViewAlleFaktura.DataSource = fakturaliste; //Indsætter listen i datagridview. 
            radioButtonAlle.Checked = true;
        }

   
        private void IndTastKunTal(KeyPressEventArgs e) // Der må kun indtastes tal i textbox
        {// Katrine
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Feltet må kun modtage tal.
            {
                e.Handled = true;
            }
        }


        private void GUIFaktura_FormClosing(object sender, FormClosingEventArgs e) 
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {   
        }
        private void labelIAltPris_Click(object sender, EventArgs e)
        {
        }
        private void buttonPDF_Click(object sender, EventArgs e)
        {   
        }
        private void textBoxFakturanummer_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxPris_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxtelefonEjer_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void dataGridViewAlleFaktura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void comboBoxRabat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void textBoxtelefonEjer_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxTlf_TextChanged(object sender, EventArgs e)
        {
        }
        private void numericUpDownAntal_ValueChanged(object sender, EventArgs e)
        {
        }

    }
}
