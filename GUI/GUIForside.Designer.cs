namespace GUI
{
    partial class GUIForside
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForside));
            this.buttonEjer = new System.Windows.Forms.Button();
            this.buttonListLageret = new System.Windows.Forms.Button();
            this.buttonBestilTid = new System.Windows.Forms.Button();
            this.buttomIndkaldDyr = new System.Windows.Forms.Button();
            this.buttonMedicinPriser = new System.Windows.Forms.Button();
            this.buttonFaktura = new System.Windows.Forms.Button();
            this.comboBoxLæger = new System.Windows.Forms.ComboBox();
            this.dataGridViewTider = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewIVenteværelset = new System.Windows.Forms.ListView();
            this.Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEjer
            // 
            this.buttonEjer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEjer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEjer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjer.Location = new System.Drawing.Point(16, 129);
            this.buttonEjer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEjer.Name = "buttonEjer";
            this.buttonEjer.Size = new System.Drawing.Size(379, 65);
            this.buttonEjer.TabIndex = 1;
            this.buttonEjer.Text = "Patientoplysninger";
            this.toolTip2.SetToolTip(this.buttonEjer, "Opret, rediger eller slet oplysninger om ejere og tilhørende dyr");
            this.buttonEjer.UseVisualStyleBackColor = false;
            this.buttonEjer.Click += new System.EventHandler(this.buttonEjer_Click);
            // 
            // buttonListLageret
            // 
            this.buttonListLageret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonListLageret.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonListLageret.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonListLageret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListLageret.Location = new System.Drawing.Point(16, 299);
            this.buttonListLageret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListLageret.Name = "buttonListLageret";
            this.buttonListLageret.Size = new System.Drawing.Size(379, 65);
            this.buttonListLageret.TabIndex = 2;
            this.buttonListLageret.Text = "Lagerstatus";
            this.toolTip5.SetToolTip(this.buttonListLageret, "Udskriv liste over lagerets status");
            this.buttonListLageret.UseVisualStyleBackColor = false;
            this.buttonListLageret.Click += new System.EventHandler(this.buttonListLageret_Click);
            // 
            // buttonBestilTid
            // 
            this.buttonBestilTid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBestilTid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBestilTid.FlatAppearance.BorderSize = 0;
            this.buttonBestilTid.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonBestilTid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonBestilTid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonBestilTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestilTid.Location = new System.Drawing.Point(16, 73);
            this.buttonBestilTid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBestilTid.Name = "buttonBestilTid";
            this.buttonBestilTid.Size = new System.Drawing.Size(379, 63);
            this.buttonBestilTid.TabIndex = 3;
            this.buttonBestilTid.Text = "Tid";
            this.toolTip1.SetToolTip(this.buttonBestilTid, "Opret en ny booking af tid til konsultation eller operation med evt. tilhørende b" +
        "ur");
            this.buttonBestilTid.UseVisualStyleBackColor = false;
            this.buttonBestilTid.Click += new System.EventHandler(this.buttonBestilTid_Click);
            // 
            // buttomIndkaldDyr
            // 
            this.buttomIndkaldDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttomIndkaldDyr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttomIndkaldDyr.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttomIndkaldDyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomIndkaldDyr.Location = new System.Drawing.Point(16, 356);
            this.buttomIndkaldDyr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttomIndkaldDyr.Name = "buttomIndkaldDyr";
            this.buttomIndkaldDyr.Size = new System.Drawing.Size(379, 57);
            this.buttomIndkaldDyr.TabIndex = 4;
            this.buttomIndkaldDyr.Text = "Indkaldelse til kontrol";
            this.toolTip6.SetToolTip(this.buttomIndkaldDyr, "Indkald ejere til kontrol af deres dyr, hvis de ikke har været på klinikken i et " +
        "år");
            this.buttomIndkaldDyr.UseVisualStyleBackColor = false;
            this.buttomIndkaldDyr.Click += new System.EventHandler(this.buttomIndkaldDyr_Click);
            // 
            // buttonMedicinPriser
            // 
            this.buttonMedicinPriser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMedicinPriser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMedicinPriser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonMedicinPriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicinPriser.Location = new System.Drawing.Point(16, 242);
            this.buttonMedicinPriser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMedicinPriser.Name = "buttonMedicinPriser";
            this.buttonMedicinPriser.Size = new System.Drawing.Size(379, 62);
            this.buttonMedicinPriser.TabIndex = 5;
            this.buttonMedicinPriser.Text = "Medicinpriser";
            this.toolTip4.SetToolTip(this.buttonMedicinPriser, "Indlæs opdaterede medicinpriser");
            this.buttonMedicinPriser.UseVisualStyleBackColor = false;
            this.buttonMedicinPriser.Click += new System.EventHandler(this.buttonMedicinPriser_Click);
            // 
            // buttonFaktura
            // 
            this.buttonFaktura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFaktura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFaktura.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaktura.Location = new System.Drawing.Point(16, 187);
            this.buttonFaktura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFaktura.Name = "buttonFaktura";
            this.buttonFaktura.Size = new System.Drawing.Size(379, 63);
            this.buttonFaktura.TabIndex = 6;
            this.buttonFaktura.Text = "Faktura";
            this.toolTip3.SetToolTip(this.buttonFaktura, "Opret nye fakturaer eller se de eksisterende");
            this.buttonFaktura.UseVisualStyleBackColor = false;
            this.buttonFaktura.Click += new System.EventHandler(this.buttonFaktura_Click);
            // 
            // comboBoxLæger
            // 
            this.comboBoxLæger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLæger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLæger.FormattingEnabled = true;
            this.comboBoxLæger.Location = new System.Drawing.Point(37, 53);
            this.comboBoxLæger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLæger.Name = "comboBoxLæger";
            this.comboBoxLæger.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLæger.TabIndex = 7;
            this.comboBoxLæger.SelectedIndexChanged += new System.EventHandler(this.comboBoxLæger_SelectedIndexChanged);
            this.comboBoxLæger.ValueMemberChanged += new System.EventHandler(this.comboBoxLæger_ValueMemberChanged);
            // 
            // dataGridViewTider
            // 
            this.dataGridViewTider.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTider.Location = new System.Drawing.Point(37, 98);
            this.dataGridViewTider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTider.Name = "dataGridViewTider";
            this.dataGridViewTider.RowHeadersWidth = 51;
            this.dataGridViewTider.RowTemplate.Height = 24;
            this.dataGridViewTider.Size = new System.Drawing.Size(1156, 729);
            this.dataGridViewTider.TabIndex = 8;
            this.dataGridViewTider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTider_CellContentClick);
            this.dataGridViewTider.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTider_CellEndEdit);
            this.dataGridViewTider.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTider_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewTider);
            this.groupBox1.Controls.Add(this.comboBoxLæger);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(460, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1232, 855);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venteliste og dagens tider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opdaterer automatisk hvert 30. sekund";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Læge";
            // 
            // listViewIVenteværelset
            // 
            this.listViewIVenteværelset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Navn});
            this.listViewIVenteværelset.HideSelection = false;
            this.listViewIVenteværelset.Location = new System.Drawing.Point(1699, 73);
            this.listViewIVenteværelset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewIVenteværelset.Name = "listViewIVenteværelset";
            this.listViewIVenteværelset.Size = new System.Drawing.Size(199, 250);
            this.listViewIVenteværelset.TabIndex = 10;
            this.listViewIVenteværelset.UseCompatibleStateImageBehavior = false;
            this.listViewIVenteværelset.SelectedIndexChanged += new System.EventHandler(this.listViewIVenteværelset_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1643, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Opdaterer automatisk hvert 5. sekund";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1753, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "I venteværelset";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = global::GUI.Properties.Resources.Done1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(29, 444);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(364, 484);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "AnimalHouse";
            // 
            // GUIForside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewIVenteværelset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFaktura);
            this.Controls.Add(this.buttonMedicinPriser);
            this.Controls.Add(this.buttomIndkaldDyr);
            this.Controls.Add(this.buttonBestilTid);
            this.Controls.Add(this.buttonListLageret);
            this.Controls.Add(this.buttonEjer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUIForside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forside";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIForside_FormClosing);
            this.Load += new System.EventHandler(this.GUIForside_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEjer;
        private System.Windows.Forms.Button buttonListLageret;
        private System.Windows.Forms.Button buttonBestilTid;
        private System.Windows.Forms.Button buttomIndkaldDyr;
        private System.Windows.Forms.Button buttonMedicinPriser;
        private System.Windows.Forms.Button buttonFaktura;
        private System.Windows.Forms.ComboBox comboBoxLæger;
        private System.Windows.Forms.DataGridView dataGridViewTider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewIVenteværelset;
        private System.Windows.Forms.ColumnHeader Navn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

