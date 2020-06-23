using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BLL;

namespace GUI
{
    public partial class GUIIndkaldelseTilKontrol : Form
    {// Ibrahim
        Controller c = new Controller();
        List<KontrolOplysninger> kontrolOplysninger = new List<KontrolOplysninger>();
        

        public GUIIndkaldelseTilKontrol()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        // Får dagens dato 
        // Kaster den videre til indkaldelseController 
        // Kalder Controller metode 
        // Viser i datagridview
        private void button1_Click(object sender, EventArgs e)
        {// Ibrahim
            DateTime dagsDato = DateTime.Today;
            c.KonvetereDag(dagsDato);
            kontrolOplysninger = c.HentBookingerTilKontrolListe(indkaldelsedatoString:c.KonvetereDag(dagsDato));
            dataGridViewPatinter.DataSource = kontrolOplysninger;
        }

        private void IndkaldelseTilKontrol_FormClosing(object sender, FormClosingEventArgs e)
        {// Ibrahim 
            GUIForside gfs = new GUIForside();
            gfs.Show();
            this.Hide();
        }

        // Knapper uden funktion.
        private void buttonKort_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void listViewPatienter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void IndkaldelseTilKontrol_Load(object sender, EventArgs e)
        {
        }
    }
}
