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
using System.IO;

namespace GUI
{
    public partial class GUILagerStatus : Form
    {// Line
        // Kalder controller og lister til denne form
        Controller c = new Controller();
        List<Salg> lagerstatusliste = new List<Salg>();
        List<Salg> lagerMinStatusListe = new List<Salg>();

        public GUILagerStatus()
        {// Line
            InitializeComponent();
            // Indlæser liste over lagervare med typesalg id 3 og 4 når programmet åbner og kalder pris der udregner indestående beløb af lagervare.
            List<Salg> lagerstatus = new List<Salg>();
            lagerstatusliste = c.HentLagerStatus();
            dataGridView1.DataSource = lagerstatusliste;
            textBoxSamletIndkøbspris.Text = Priser().ToString();
        }
       
        private void GUILagerStatus_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 200;
        }

        // Udskriver listen over vare til textfil AnimalHouseLagerStatus
        private void buttonPrintListe_Click(object sender, EventArgs e)
        {// Line
          //  Opretter filnavn AnimaleHouseLagerStatus
            string filnavn = "AnimaleHouseLagerStatus";
            filnavn = $"{filnavn}.txt";
            StreamWriter outputStream = new StreamWriter(filnavn);

            //Udskriver datagridview til textfilen.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string output = dataGridView1.Rows[i].Cells[j].Value.ToString();
                   
                    outputStream.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    if (output.Length >= 9)
                    {
                        outputStream.Write("\t");
                    }
                    else
                    {
                        outputStream.Write("\t \t");
                    }
                }
                outputStream.WriteLine("");
            }
            outputStream.WriteLine("");
            outputStream.Write("\t \t \t \t \t \t \t \t \t \t" + "Samlet beløb:   " + textBoxSamletIndkøbspris.Text);

            System.Diagnostics.Process.Start(filnavn);

            if (outputStream != null)
                outputStream.Close();
        }

        // Knappen viser alle typesalg 3 og 4 som er under 10 i antal.
        private void buttonSelavstatus_Click(object sender, EventArgs e)
        {// Line
            lagerMinStatusListe = c.HentLagerMinLagerStatus();
            dataGridView1.DataSource = lagerMinStatusListe;
            textBoxSamletIndkøbspris.Text = Priser().ToString();
        }

        // Knappen giver den oprindelige liste med alle typesalg 3 og 4. 
        private void buttonLagerVare_Click(object sender, EventArgs e)
        {// Line
            lagerstatusliste = c.HentLagerStatus();
            dataGridView1.DataSource = lagerstatusliste;
            textBoxSamletIndkøbspris.Text = Priser().ToString();
        }

        // Når lagerstatus lukkes, kommer man retur til forside.
        private void GUILagerStatus_FormClosing(object sender, FormClosingEventArgs e)
        {// Line
            this.Hide();
            GUIForside gf1 = new GUIForside();
            gf1.Show();
        }

        // Metoder: 

        // Metoden udregner den samlede indkøbspris af vare på lager.
        private decimal Priser()
        {//Line
            decimal antal;
            decimal indkøbspris;
            decimal sum;
            decimal samletsum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                antal = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                indkøbspris = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                sum = indkøbspris * antal;
                dataGridView1.Rows[i].Cells[6].Value = sum;
                samletsum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);

            }
            return samletsum;
        }

        // Knapper uden funktion:
        private void textBoxSamletIndkøbspris_TextChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
