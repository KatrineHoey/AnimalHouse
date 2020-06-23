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
using EntityLayer;
using BLL;
using System.Globalization;

namespace GUI
{
    public partial class GUIMedicinpriser : Form
    {//Ibrahim
        Controller c = new Controller();
 
        public GUIMedicinpriser()
        {
            InitializeComponent();
        }

        // Opretter Colmums titler 
        private void GUIMedicinpriser_Load(object sender, EventArgs e)
        {//Ibrahim

            listViewMedicin.View = View.Details;
            listViewMedicin.FullRowSelect = true;

            listViewMedicin.Columns.Add("Varenummer",120);
            listViewMedicin.Columns.Add("Medicin",310);
            listViewMedicin.Columns.Add("IndkøbsPris",120);
        }
        // indlæser medicinpriser som nova Nova formel
        private void IndlæsNovaPriser()
        {//Ibrahim
            // åbener "stifinder" vindue og filen kan vælges.
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            using (var sr = new StreamReader(myStream))
                            {
                                var line = string.Empty;
                                while ((line = sr.ReadLine()) != null) // Loop mens der er flere data
                                {
                                    string[] lineItems = line.Split(new string[] { "," }, StringSplitOptions.None); // Split linjer
                                    ListViewItem medicinlist = new ListViewItem();
                                    var varenummer = medicinlist.Text = lineItems[1];
                                    var beskrivelse = medicinlist.SubItems.Add(lineItems[0]);
                                    var pris = medicinlist.SubItems.Add(lineItems[2]);
                                    listViewMedicin.Items.Add(medicinlist); // Tilføjer en ny listview item (varenummer, Beskrivelse, Pris)
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Opps! : " + ex.Message);
                }
            }
        }
        // indlæser medicinpriser som nova Nomeco formel
        private void IndlæsNomecoPriser()
        {// Ibrahim
            // åbener "stifinder" vindue og filen kan vælges.
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();

            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            using (var sr = new StreamReader(myStream))
                            {
                                var line = string.Empty;
                                while ((line = sr.ReadLine()) != null) // Loop mens der er flere data
                                {
                                    string[] lineItems = line.Split(new string[] { "," }, StringSplitOptions.None); // Split linjer
                                    ListViewItem medicinlist = new ListViewItem();
                                    var varenummer = medicinlist.Text = lineItems[0];
                                    var beskrivelse = medicinlist.SubItems.Add(lineItems[1]);
                                    var pris = medicinlist.SubItems.Add(lineItems[2]);
                                    listViewMedicin.Items.Add(medicinlist); // Tilføjer en ny listview item (varenummer, Beskrivelse, Pris)
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Opps! : " + ex.Message);
                }
            }
        }

        // Kalder metoden til Nova formel
        private void buttonHentMedicin_Click(object sender, EventArgs e)
        {// Ibrahim
            listViewMedicin.Items.Clear();
            IndlæsNovaPriser();
        }
        // Kalder metoden til Nomeco formel
        private void buttonNomeco_Click(object sender, EventArgs e)
        {// Ibrahim
            listViewMedicin.Items.Clear();
            IndlæsNomecoPriser();
        }

        // Gem priser i databasen samt salgs prisen
        private void buttonOpdaterePriser_Click(object sender, EventArgs e)
        {// Ibrahim  
            int i = 0;
            int j = 0;
            try
            {
                int antal = listViewMedicin.Items.Count;
                if (antal == 0)
                {
                    MessageBox.Show("Listen er tom");
                }
                else
                {
                    j = listViewMedicin.Items.Count;
                    for (i = 0; i <= j - 1; i++)
                    {
                        string varenummer = listViewMedicin.Items[i].SubItems[0].Text;
                        decimal indkøbspris = decimal.Parse(listViewMedicin.Items[i].SubItems[2].Text, CultureInfo.InvariantCulture);
                        decimal salgspris = indkøbspris * 2;
                        c.IndlæsMedicinPriser(varenummer, indkøbspris, salgspris);
                    }
                    MessageBox.Show("Priserne er opdateret");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GUIMedicinpriser_FormClosing(object sender, FormClosingEventArgs e)
        {// Ibrahim
            this.Hide();
            GUIForside gf1 = new GUIForside();
            gf1.Show();
        }
        // Knapper unden funktion.

        private void listViewMedicin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
