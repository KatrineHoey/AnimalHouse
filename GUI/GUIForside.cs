using BLL;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class GUIForside : Form
    {
        Controller c = new Controller();
        List<Dyrlæge> dyrlægeliste = new List<Dyrlæge>();
        static string dyrlægenavn = "Alle";
        private Thread dagensTider;
        private Thread venteliste;

        public GUIForside()
        {
            InitializeComponent();
        }

        private void GUIForside_Load(object sender, EventArgs e)
        { //Katrine

            //Tjekker om der er internet - ellers kan programmet ikke køre.
            TjekForbindelse(); 

            //Henter dyrlæger fra databasen og indsætter i combobox. 
            comboBoxLæger.Items.Add("Alle");
            dyrlægeliste = c.HentLægeListe();
            foreach (Dyrlæge l in dyrlægeliste)
            {
                comboBoxLæger.Items.Add(l.Navn);
            }
            comboBoxLæger.SelectedItem = dyrlægenavn;


            //Starter tråd som opdatere dagens tider hvert 30. sekund. 
            DagensTiderTråd dagensTiderTråd = new DagensTiderTråd(dataGridViewTider, dateTimePicker1, comboBoxLæger);
            dagensTider = new Thread(new ThreadStart(dagensTiderTråd.OpdaterVenteliste));
            dagensTider.IsBackground = true;
            dagensTider.Start();

            //Starter tråd som opdatere venteliste hvert 5. sekund. 
            listViewIVenteværelset.Columns[0].Text = "Navn";
            listViewIVenteværelset.View = View.Details;
            Venteliste venteListe = new Venteliste(listViewIVenteværelset, comboBoxLæger);
            venteliste = new Thread(new ThreadStart(venteListe.OpdaterVenteliste));
            venteliste.IsBackground = true;
            venteliste.Start();

        }

        private void buttonBestilTid_Click(object sender, EventArgs e) //Åbner nyt vindue
        { //Irfan og Katrine
            GUIBestilTid guiBestilTid = new GUIBestilTid();
            dagensTider.Abort();
            venteliste.Abort();
            guiBestilTid.Show();
            this.Hide();
        }

        private void buttonEjer_Click(object sender, EventArgs e) //Åbner nyt vindue
        { //Katrine 
            GUIVisEjer guiEjer = new GUIVisEjer();
            dagensTider.Abort();
            venteliste.Abort();
            if (dataGridViewTider.SelectedRows.Count == 1) //Flytter data fra en valgt booking fra datagridview til patientoplysninger-vinduet. 
            {
                guiEjer.textBoxFindEjer.Text = dataGridViewTider.Rows[0].Cells[4].Value.ToString();
            }
            guiEjer.Show();
            this.Hide();

        }

        private void buttonMedicinPriser_Click(object sender, EventArgs e) //Åbner nyt vindue
        { //Irfan og Katrine
            GUIMedicinpriser mp = new GUIMedicinpriser();
            dagensTider.Abort();
            venteliste.Abort();
            mp.Show();
            this.Hide();
        }

        private void buttonFaktura_Click(object sender, EventArgs e) //Åbner nyt vindue
        { //Katrine
            
            GUIFaktura guiFaktura = new GUIFaktura();
            dagensTider.Abort();
            venteliste.Abort();
            if (dataGridViewTider.SelectedRows.Count == 1) //Flytter data fra en valgt booking fra datagridview til faktura-vinduet. 
            {
                guiFaktura.textBoxtelefonEjer.Text = dataGridViewTider.Rows[0].Cells[4].Value.ToString();
            }            
            guiFaktura.Show();

            this.Hide();
        }

        private void buttomIndkaldDyr_Click(object sender, EventArgs e) //Åbner nyt vindue
        {//Irfan og Katrine
            GUIIndkaldelseTilKontrol guiIndkald = new GUIIndkaldelseTilKontrol();
            dagensTider.Abort();
            venteliste.Abort();
            guiIndkald.Show();
            this.Hide();
        }

        private void buttonListLageret_Click(object sender, EventArgs e) //Åbner nyt vindue
        { //Irfan og Katrine
            GUILagerStatus guiLagerStatus = new GUILagerStatus();
            dagensTider.Abort();
            venteliste.Abort();
            guiLagerStatus.Show();
            this.Hide();
        }


        private void comboBoxLæger_SelectedIndexChanged(object sender, EventArgs e)
        { //Katrine

            //Gemmer den valgte dyrlæge til næste gang denne form bliver åbnet. 
            dyrlægenavn = comboBoxLæger.Text;

            if (dagensTider != null) //Tjekker om dagenstidertråden er startet før den forsøges restartet. 
            {
                RestartTrådDagensTider();
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {//Katrine
            RestartTrådDagensTider();            
        }

        private void GUIForside_FormClosing(object sender, FormClosingEventArgs e)
        { //Ibrahim
            Application.Exit();
        }

        // Metoder

        private void RestartTrådDagensTider()
        {//Katrine
            //Restarter tråden.
            dagensTider.Abort();

            //Starter tråd som opdatere venteliste hvert 5. sekund. 
            DagensTiderTråd dagensTiderTråd = new DagensTiderTråd(dataGridViewTider, dateTimePicker1, comboBoxLæger);
            dagensTider = new Thread(new ThreadStart(dagensTiderTråd.OpdaterVenteliste));
            dagensTider.IsBackground = true;
            dagensTider.Start();
        }

        private void TjekForbindelse()
        { //Ibrahim
            string conString = "Data Source=den1.mssql8.gear.host; Initial Catalog=animalhouseucl; User Id=animalhouseucl; Password=Kr0suY91u??2";
            SqlConnection cnn = new SqlConnection(conString);
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " /b upss der er noget galt i forbindelse til databasen");
                Application.Exit();
            }
        }

        // Knapper uden funktion.
        private void dataGridViewTider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridViewTider_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridViewTider_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void comboBoxLæger_ValueMemberChanged(object sender, EventArgs e)
        {
        }
        private void listViewIVenteværelset_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
    }

    // Egne oprettet klasser til at håndtere tråde på forsiden.

    public class Venteliste //Ny klasse til at håndtere listview med venteliste 
    {//Katrine
        Controller c = new Controller();
        private ListView listView;
        private ComboBox comboBox;

        private delegate void DisplayDelegate(List<string> navn); // bruges til at indsætte og hente data på skærmbilledet. 
        private delegate string GetDelegate(ComboBox cb);

        public Venteliste(ListView listView, ComboBox comboBox)
        {//Katrine
            this.listView = listView;
            this.comboBox = comboBox;
        }

        public string HentLæge(ComboBox cb)
        {//Katrine
            return cb.Text; //Returere den valgte læge 
        }

        public void VisVenteliste(List<string> navn) //Viser ventelisten på skærmen i et listview
        {//Katrine
            listView.Items.Clear();

            foreach (string n in navn)
            {
                listView.Items.Add(n);
            }
            
        }

        public void OpdaterVenteliste() //metoden tråden kalder. 
        {//Katrine
            while (true)
            {
                string lægevalg = "Alle";

                if (comboBox.InvokeRequired) //Hent den valgte læge.
                {
                    lægevalg = (string)comboBox.Invoke(new GetDelegate(HentLæge), new Object[] { comboBox });
                }
                else
                    lægevalg = comboBox.Text;

                List<string> navne = c.HentNavnPåEjerSomVenter(lægevalg); //Henter fra databasen, dem som venter.

                if (listView.InvokeRequired) //Vis data i listview. 
                {
                    listView.Invoke(new DisplayDelegate(VisVenteliste), new Object[] { navne });
                }
                else
                    VisVenteliste(navne);


                Thread.Sleep(5000); //Tråden venter 5 sekunder inden den fortsætter. 
            }
        }
    }

    public class DagensTiderTråd //Ny klasse til at håndtere dagens tider i en tråd i datagridview. 
    { //Katrine

        Controller c = new Controller();
        private DataGridView dataGridView;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBox;

        private delegate void DisplayDelegate(DataTable dataTable); // bruges til at indsætte og hente data på skærmbilledet. 
        private delegate string GetDelegate(ComboBox comboBox);
        private delegate void DisplayDelegate2();

        public DagensTiderTråd(DataGridView dataGridView, DateTimePicker dateTimePicker, ComboBox comboBox)
        {//Katrine
            this.dataGridView = dataGridView;
            this.dateTimePicker = dateTimePicker;
            this.comboBox = comboBox;
            VisDatagridview(); 
        }


        public void VisDatagridview()
        {//Katrine
            //Tilføj overskrifter og combobox til datagridview. Metoden er nødvendig for at implementere comboboxen.   
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Clear();

            DataGridViewComboBoxColumn ankommet = new DataGridViewComboBoxColumn();
            var ankommetSvar = new List<string>() { "Ikke ankommet", "Venter", "Inde", "Afsluttet" };
            ankommet.DataSource = ankommetSvar;
            ankommet.HeaderCell.Value = "Ankommet";
            ankommet.DataPropertyName = "Ankommet";
            

            DataGridViewTextBoxColumn tidspunkt = new DataGridViewTextBoxColumn();
            tidspunkt.HeaderText = "Tidspunkt";
            tidspunkt.DataPropertyName = "Tidspunkt";

            DataGridViewTextBoxColumn bookingID = new DataGridViewTextBoxColumn();
            bookingID.HeaderText = "BookingID";
            bookingID.DataPropertyName = "BookingID";

            DataGridViewTextBoxColumn navn = new DataGridViewTextBoxColumn();
            navn.HeaderText = "Navn";
            navn.DataPropertyName = "Navn";

            DataGridViewTextBoxColumn behandlingstype = new DataGridViewTextBoxColumn();
            behandlingstype.HeaderText = "Behandlingstype";
            behandlingstype.DataPropertyName = "Behandlingstype";

            DataGridViewTextBoxColumn kommentar = new DataGridViewTextBoxColumn();
            kommentar.HeaderText = "Kommentar";
            kommentar.DataPropertyName = "Kommentar";

            DataGridViewTextBoxColumn dyrlæge = new DataGridViewTextBoxColumn();
            dyrlæge.HeaderText = "Dyrlæge";
            dyrlæge.DataPropertyName = "Dyrlæge";

            DataGridViewTextBoxColumn tlfnummer = new DataGridViewTextBoxColumn();
            tlfnummer.HeaderText = "Tlf";
            tlfnummer.DataPropertyName = "Tlf";

            dataGridView.Columns.AddRange(bookingID, ankommet, tidspunkt, navn, tlfnummer, behandlingstype, kommentar, dyrlæge);
        }

        public void VisDataTableIDataGridView(DataTable dataTable)
        {//Katrine
            dataGridView.DataSource = dataTable; //Indsætter data i datagridview. 
        }

        public string HentLæge(ComboBox comboBox)
        {//Katrine
            return comboBox.Text; //Henter den valgte læge. 
        }

        public void OpdatereDatasource()
        {//Katrine
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string ankommet = dataGridView.Rows[i].Cells[1].Value.ToString(); //Tjekker om status på ankommet er ændret. 
                int bookingID = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
                c.OpdaterVenteliste(ankommet, bookingID); //Opdatere en evt. ændring. 

            }
        }


        public void OpdaterVenteliste() //Metoden som tråden kalder. 
        {//Katrine
            while (true)
            {
                string dato = dateTimePicker.Value.ToString("yyyy-MM-dd");
                string lægevalg = "Alle";

                if (comboBox.InvokeRequired) //Hent den valgte læge.
                {
                    lægevalg = (string)comboBox.Invoke(new GetDelegate(HentLæge), new Object[] { comboBox });
                }
                else
                    lægevalg = comboBox.Text;


                if (dataGridView.InvokeRequired) //Hent status data fra datagridview.
                {
                    dataGridView.Invoke(new DisplayDelegate2(OpdatereDatasource));
                }
                else
                    OpdatereDatasource();


                DataTable dt = c.HentDatatableVenteliste(dato, lægevalg); //Henter datatable fra controlleren med informationer fra databasen. 

                if (dataGridView.InvokeRequired) //Vis data i datagridview.
                {
                    dataGridView.Invoke(new DisplayDelegate(VisDataTableIDataGridView), new Object[] { dt });
                }
                else
                    VisDataTableIDataGridView(dt);


                Thread.Sleep(30000); //Tråden venter 30 sekunder inden den fortsætter. 
            }
        }

   

    }
}
