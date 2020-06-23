

namespace GUI
{
    partial class GUIFaktura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIFaktura));
            this.comboBoxBehandlingstype = new System.Windows.Forms.ComboBox();
            this.labelSalgsstype = new System.Windows.Forms.Label();
            this.comboBoxVarer = new System.Windows.Forms.ComboBox();
            this.labelMedicin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNavn = new System.Windows.Forms.TextBox();
            this.labelNavn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRabat = new System.Windows.Forms.ComboBox();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.numericUpDownAntal = new System.Windows.Forms.NumericUpDown();
            this.labelIAltPris = new System.Windows.Forms.Label();
            this.labelPrisIAlt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAntal = new System.Windows.Forms.Label();
            this.buttonSletFaktura = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonErBetalt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonErIkkeBetalt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtelefonEjer = new System.Windows.Forms.TextBox();
            this.buttonSletLinje = new System.Windows.Forms.Button();
            this.buttonGem = new System.Windows.Forms.Button();
            this.buttonTilføjTilFaktura = new System.Windows.Forms.Button();
            this.buttonSøg = new System.Windows.Forms.Button();
            this.textBoxFakturanummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFakturaLinjer = new System.Windows.Forms.DataGridView();
            this.groupBoxAlleFaktura = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSøgEjer = new System.Windows.Forms.Button();
            this.textBoxTlf = new System.Windows.Forms.TextBox();
            this.radioButtonBetalt = new System.Windows.Forms.RadioButton();
            this.radioButtonIkkeBetalt = new System.Windows.Forms.RadioButton();
            this.radioButtonAlle = new System.Windows.Forms.RadioButton();
            this.dataGridViewAlleFaktura = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakturaLinjer)).BeginInit();
            this.groupBoxAlleFaktura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlleFaktura)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBehandlingstype
            // 
            this.comboBoxBehandlingstype.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxBehandlingstype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBehandlingstype.FormattingEnabled = true;
            this.comboBoxBehandlingstype.Location = new System.Drawing.Point(23, 133);
            this.comboBoxBehandlingstype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBehandlingstype.Name = "comboBoxBehandlingstype";
            this.comboBoxBehandlingstype.Size = new System.Drawing.Size(179, 28);
            this.comboBoxBehandlingstype.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxBehandlingstype, "Vælg salgstype");
            this.comboBoxBehandlingstype.SelectedIndexChanged += new System.EventHandler(this.comboBoxBehandlingstype_SelectedIndexChanged);
            // 
            // labelSalgsstype
            // 
            this.labelSalgsstype.AutoSize = true;
            this.labelSalgsstype.Location = new System.Drawing.Point(23, 110);
            this.labelSalgsstype.Name = "labelSalgsstype";
            this.labelSalgsstype.Size = new System.Drawing.Size(82, 20);
            this.labelSalgsstype.TabIndex = 2;
            this.labelSalgsstype.Text = "Salgstype";
            this.labelSalgsstype.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxVarer
            // 
            this.comboBoxVarer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxVarer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVarer.FormattingEnabled = true;
            this.comboBoxVarer.Location = new System.Drawing.Point(267, 133);
            this.comboBoxVarer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxVarer.Name = "comboBoxVarer";
            this.comboBoxVarer.Size = new System.Drawing.Size(285, 28);
            this.comboBoxVarer.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxVarer, "Vælg vare");
            this.comboBoxVarer.SelectedIndexChanged += new System.EventHandler(this.comboBoxVarer_SelectedIndexChanged);
            // 
            // labelMedicin
            // 
            this.labelMedicin.AutoSize = true;
            this.labelMedicin.Location = new System.Drawing.Point(264, 110);
            this.labelMedicin.Name = "labelMedicin";
            this.labelMedicin.Size = new System.Drawing.Size(42, 20);
            this.labelMedicin.TabIndex = 5;
            this.labelMedicin.Text = "Salg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNavn);
            this.groupBox1.Controls.Add(this.labelNavn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxRabat);
            this.groupBox1.Controls.Add(this.buttonPDF);
            this.groupBox1.Controls.Add(this.numericUpDownAntal);
            this.groupBox1.Controls.Add(this.labelIAltPris);
            this.groupBox1.Controls.Add(this.labelPrisIAlt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPris);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelAntal);
            this.groupBox1.Controls.Add(this.buttonSletFaktura);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButtonErBetalt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonErIkkeBetalt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxtelefonEjer);
            this.groupBox1.Controls.Add(this.buttonSletLinje);
            this.groupBox1.Controls.Add(this.buttonGem);
            this.groupBox1.Controls.Add(this.buttonTilføjTilFaktura);
            this.groupBox1.Controls.Add(this.buttonSøg);
            this.groupBox1.Controls.Add(this.textBoxFakturanummer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewFakturaLinjer);
            this.groupBox1.Controls.Add(this.labelSalgsstype);
            this.groupBox1.Controls.Add(this.comboBoxBehandlingstype);
            this.groupBox1.Controls.Add(this.labelMedicin);
            this.groupBox1.Controls.Add(this.comboBoxVarer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(843, 642);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linjer til faktura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(267, 49);
            this.textBoxNavn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(177, 26);
            this.textBoxNavn.TabIndex = 34;
            this.toolTip1.SetToolTip(this.textBoxNavn, "Navn på ejeren");
            // 
            // labelNavn
            // 
            this.labelNavn.AutoSize = true;
            this.labelNavn.Location = new System.Drawing.Point(263, 21);
            this.labelNavn.Name = "labelNavn";
            this.labelNavn.Size = new System.Drawing.Size(47, 20);
            this.labelNavn.TabIndex = 33;
            this.labelNavn.Text = "Navn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Antal stk.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rabat i %:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxRabat
            // 
            this.comboBoxRabat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxRabat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRabat.FormattingEnabled = true;
            this.comboBoxRabat.Location = new System.Drawing.Point(409, 213);
            this.comboBoxRabat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRabat.Name = "comboBoxRabat";
            this.comboBoxRabat.Size = new System.Drawing.Size(69, 28);
            this.comboBoxRabat.TabIndex = 30;
            this.toolTip1.SetToolTip(this.comboBoxRabat, "Giv procentmæssig rabat på varens pris");
            this.comboBoxRabat.SelectedIndexChanged += new System.EventHandler(this.comboBoxRabat_SelectedIndexChanged);
            // 
            // buttonPDF
            // 
            this.buttonPDF.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPDF.Enabled = false;
            this.buttonPDF.Location = new System.Drawing.Point(732, 578);
            this.buttonPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 36);
            this.buttonPDF.TabIndex = 29;
            this.buttonPDF.Text = "PDF";
            this.toolTip1.SetToolTip(this.buttonPDF, "Udskriv fakturaen til en PDF-fil");
            this.buttonPDF.UseVisualStyleBackColor = false;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // numericUpDownAntal
            // 
            this.numericUpDownAntal.Location = new System.Drawing.Point(21, 217);
            this.numericUpDownAntal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownAntal.Name = "numericUpDownAntal";
            this.numericUpDownAntal.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAntal.TabIndex = 28;
            this.toolTip1.SetToolTip(this.numericUpDownAntal, "Vælg antal af en given vare");
            this.numericUpDownAntal.ValueChanged += new System.EventHandler(this.numericUpDownAntal_ValueChanged);
            this.numericUpDownAntal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownAntal_KeyPress);
            // 
            // labelIAltPris
            // 
            this.labelIAltPris.AutoSize = true;
            this.labelIAltPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIAltPris.Location = new System.Drawing.Point(743, 548);
            this.labelIAltPris.Name = "labelIAltPris";
            this.labelIAltPris.Size = new System.Drawing.Size(36, 17);
            this.labelIAltPris.TabIndex = 27;
            this.labelIAltPris.Text = "0 kr";
            this.labelIAltPris.Click += new System.EventHandler(this.labelIAltPris_Click);
            // 
            // labelPrisIAlt
            // 
            this.labelPrisIAlt.AutoSize = true;
            this.labelPrisIAlt.Location = new System.Drawing.Point(729, 554);
            this.labelPrisIAlt.Name = "labelPrisIAlt";
            this.labelPrisIAlt.Size = new System.Drawing.Size(0, 20);
            this.labelPrisIAlt.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pris i alt:";
            // 
            // textBoxPris
            // 
            this.textBoxPris.Location = new System.Drawing.Point(267, 217);
            this.textBoxPris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(123, 26);
            this.textBoxPris.TabIndex = 24;
            this.toolTip1.SetToolTip(this.textBoxPris, "Vælg pris");
            this.textBoxPris.TextChanged += new System.EventHandler(this.textBoxPris_TextChanged);
            this.textBoxPris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPris_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pris";
            // 
            // labelAntal
            // 
            this.labelAntal.AutoSize = true;
            this.labelAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntal.Location = new System.Drawing.Point(19, 188);
            this.labelAntal.Name = "labelAntal";
            this.labelAntal.Size = new System.Drawing.Size(52, 24);
            this.labelAntal.TabIndex = 21;
            this.labelAntal.Text = "Antal";
            // 
            // buttonSletFaktura
            // 
            this.buttonSletFaktura.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSletFaktura.Location = new System.Drawing.Point(23, 578);
            this.buttonSletFaktura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSletFaktura.Name = "buttonSletFaktura";
            this.buttonSletFaktura.Size = new System.Drawing.Size(139, 36);
            this.buttonSletFaktura.TabIndex = 20;
            this.buttonSletFaktura.Text = "Slet Faktura";
            this.toolTip1.SetToolTip(this.buttonSletFaktura, "Slet fakturaen fra listen");
            this.buttonSletFaktura.UseVisualStyleBackColor = false;
            this.buttonSletFaktura.Click += new System.EventHandler(this.buttonSletFaktura_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Vælg dato på oprettelse af faktura");
            // 
            // radioButtonErBetalt
            // 
            this.radioButtonErBetalt.AutoSize = true;
            this.radioButtonErBetalt.Location = new System.Drawing.Point(539, 583);
            this.radioButtonErBetalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonErBetalt.Name = "radioButtonErBetalt";
            this.radioButtonErBetalt.Size = new System.Drawing.Size(74, 24);
            this.radioButtonErBetalt.TabIndex = 15;
            this.radioButtonErBetalt.TabStop = true;
            this.radioButtonErBetalt.Text = "Betalt";
            this.toolTip1.SetToolTip(this.radioButtonErBetalt, "Markér fakturaen som betalt");
            this.radioButtonErBetalt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dato";
            // 
            // radioButtonErIkkeBetalt
            // 
            this.radioButtonErIkkeBetalt.AutoSize = true;
            this.radioButtonErIkkeBetalt.Location = new System.Drawing.Point(411, 583);
            this.radioButtonErIkkeBetalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonErIkkeBetalt.Name = "radioButtonErIkkeBetalt";
            this.radioButtonErIkkeBetalt.Size = new System.Drawing.Size(105, 24);
            this.radioButtonErIkkeBetalt.TabIndex = 14;
            this.radioButtonErIkkeBetalt.TabStop = true;
            this.radioButtonErIkkeBetalt.Text = "Ikke betalt";
            this.toolTip1.SetToolTip(this.radioButtonErIkkeBetalt, "Markér fakturaen som ikke betalt");
            this.radioButtonErIkkeBetalt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tlf. nummer";
            // 
            // textBoxtelefonEjer
            // 
            this.textBoxtelefonEjer.Location = new System.Drawing.Point(27, 49);
            this.textBoxtelefonEjer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxtelefonEjer.Name = "textBoxtelefonEjer";
            this.textBoxtelefonEjer.Size = new System.Drawing.Size(177, 26);
            this.textBoxtelefonEjer.TabIndex = 15;
            this.textBoxtelefonEjer.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxtelefonEjer, "Indtast tlf. nummer. 1 er til ukendte kunder");
            this.textBoxtelefonEjer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxtelefonEjer_MouseClick);
            this.textBoxtelefonEjer.TextChanged += new System.EventHandler(this.textBoxtelefonEjer_TextChanged);
            this.textBoxtelefonEjer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtelefonEjer_KeyPress);
            // 
            // buttonSletLinje
            // 
            this.buttonSletLinje.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSletLinje.Location = new System.Drawing.Point(23, 287);
            this.buttonSletLinje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSletLinje.Name = "buttonSletLinje";
            this.buttonSletLinje.Size = new System.Drawing.Size(139, 36);
            this.buttonSletLinje.TabIndex = 14;
            this.buttonSletLinje.Text = "Slet linje";
            this.toolTip1.SetToolTip(this.buttonSletLinje, "Slet linje fra fakturaen");
            this.buttonSletLinje.UseVisualStyleBackColor = false;
            this.buttonSletLinje.Click += new System.EventHandler(this.buttonSletLinje_Click);
            // 
            // buttonGem
            // 
            this.buttonGem.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonGem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGem.Location = new System.Drawing.Point(651, 578);
            this.buttonGem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGem.Name = "buttonGem";
            this.buttonGem.Size = new System.Drawing.Size(75, 36);
            this.buttonGem.TabIndex = 13;
            this.buttonGem.Text = "Gem";
            this.toolTip1.SetToolTip(this.buttonGem, "Gem fakturaen med alle dens oplysninger");
            this.buttonGem.UseVisualStyleBackColor = false;
            this.buttonGem.Click += new System.EventHandler(this.buttonGem_Click);
            // 
            // buttonTilføjTilFaktura
            // 
            this.buttonTilføjTilFaktura.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTilføjTilFaktura.Location = new System.Drawing.Point(641, 209);
            this.buttonTilføjTilFaktura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTilføjTilFaktura.Name = "buttonTilføjTilFaktura";
            this.buttonTilføjTilFaktura.Size = new System.Drawing.Size(165, 36);
            this.buttonTilføjTilFaktura.TabIndex = 12;
            this.buttonTilføjTilFaktura.Text = "Tilføj til faktura";
            this.toolTip1.SetToolTip(this.buttonTilføjTilFaktura, "Tilføj varen til faktura baseret på pris og antal");
            this.buttonTilføjTilFaktura.UseVisualStyleBackColor = false;
            this.buttonTilføjTilFaktura.Click += new System.EventHandler(this.buttonTilføjTilFaktura_Click);
            // 
            // buttonSøg
            // 
            this.buttonSøg.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSøg.Location = new System.Drawing.Point(732, 286);
            this.buttonSøg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSøg.Name = "buttonSøg";
            this.buttonSøg.Size = new System.Drawing.Size(75, 36);
            this.buttonSøg.TabIndex = 11;
            this.buttonSøg.Text = "Søg";
            this.toolTip1.SetToolTip(this.buttonSøg, "Søg på en faktura udfra indtastet fakturanummer");
            this.buttonSøg.UseVisualStyleBackColor = false;
            this.buttonSøg.Click += new System.EventHandler(this.buttonSøg_Click);
            // 
            // textBoxFakturanummer
            // 
            this.textBoxFakturanummer.Location = new System.Drawing.Point(523, 290);
            this.textBoxFakturanummer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFakturanummer.Name = "textBoxFakturanummer";
            this.textBoxFakturanummer.Size = new System.Drawing.Size(204, 26);
            this.textBoxFakturanummer.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxFakturanummer, "Indtast fakturanummer");
            this.textBoxFakturanummer.TextChanged += new System.EventHandler(this.textBoxFakturanummer_TextChanged);
            this.textBoxFakturanummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFakturanummer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fakturanummer:";
            // 
            // dataGridViewFakturaLinjer
            // 
            this.dataGridViewFakturaLinjer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewFakturaLinjer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFakturaLinjer.Location = new System.Drawing.Point(21, 329);
            this.dataGridViewFakturaLinjer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewFakturaLinjer.Name = "dataGridViewFakturaLinjer";
            this.dataGridViewFakturaLinjer.RowHeadersWidth = 51;
            this.dataGridViewFakturaLinjer.RowTemplate.Height = 24;
            this.dataGridViewFakturaLinjer.Size = new System.Drawing.Size(787, 212);
            this.dataGridViewFakturaLinjer.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dataGridViewFakturaLinjer, "Salgslinjer til en faktura");
            // 
            // groupBoxAlleFaktura
            // 
            this.groupBoxAlleFaktura.Controls.Add(this.button1);
            this.groupBoxAlleFaktura.Controls.Add(this.buttonSøgEjer);
            this.groupBoxAlleFaktura.Controls.Add(this.textBoxTlf);
            this.groupBoxAlleFaktura.Controls.Add(this.radioButtonBetalt);
            this.groupBoxAlleFaktura.Controls.Add(this.radioButtonIkkeBetalt);
            this.groupBoxAlleFaktura.Controls.Add(this.radioButtonAlle);
            this.groupBoxAlleFaktura.Controls.Add(this.dataGridViewAlleFaktura);
            this.groupBoxAlleFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAlleFaktura.Location = new System.Drawing.Point(916, 112);
            this.groupBoxAlleFaktura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAlleFaktura.Name = "groupBoxAlleFaktura";
            this.groupBoxAlleFaktura.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAlleFaktura.Size = new System.Drawing.Size(827, 642);
            this.groupBoxAlleFaktura.TabIndex = 9;
            this.groupBoxAlleFaktura.TabStop = false;
            this.groupBoxAlleFaktura.Text = "Alle fakturaer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(745, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button1, "Opdater listen med fakture på skærmbilledet");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSøgEjer
            // 
            this.buttonSøgEjer.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSøgEjer.Location = new System.Drawing.Point(591, 48);
            this.buttonSøgEjer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSøgEjer.Name = "buttonSøgEjer";
            this.buttonSøgEjer.Size = new System.Drawing.Size(127, 36);
            this.buttonSøgEjer.TabIndex = 13;
            this.buttonSøgEjer.Text = "Søg efter tlf.";
            this.toolTip1.SetToolTip(this.buttonSøgEjer, "Søg efter fakturaer udfra telefonnummer");
            this.buttonSøgEjer.UseVisualStyleBackColor = false;
            this.buttonSøgEjer.Click += new System.EventHandler(this.buttonSøgEjer_Click);
            // 
            // textBoxTlf
            // 
            this.textBoxTlf.Location = new System.Drawing.Point(444, 53);
            this.textBoxTlf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTlf.Name = "textBoxTlf";
            this.textBoxTlf.Size = new System.Drawing.Size(141, 26);
            this.textBoxTlf.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxTlf, "Indtast telefonnummer tilknyttet til en faktura");
            this.textBoxTlf.TextChanged += new System.EventHandler(this.textBoxTlf_TextChanged);
            this.textBoxTlf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTlf_KeyPress);
            // 
            // radioButtonBetalt
            // 
            this.radioButtonBetalt.AutoSize = true;
            this.radioButtonBetalt.Location = new System.Drawing.Point(251, 54);
            this.radioButtonBetalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonBetalt.Name = "radioButtonBetalt";
            this.radioButtonBetalt.Size = new System.Drawing.Size(74, 24);
            this.radioButtonBetalt.TabIndex = 11;
            this.radioButtonBetalt.TabStop = true;
            this.radioButtonBetalt.Text = "Betalt";
            this.toolTip1.SetToolTip(this.radioButtonBetalt, "Vis kun betalte fakturaer");
            this.radioButtonBetalt.UseVisualStyleBackColor = true;
            this.radioButtonBetalt.CheckedChanged += new System.EventHandler(this.radioButtonBetalt_CheckedChanged);
            // 
            // radioButtonIkkeBetalt
            // 
            this.radioButtonIkkeBetalt.AutoSize = true;
            this.radioButtonIkkeBetalt.Location = new System.Drawing.Point(117, 50);
            this.radioButtonIkkeBetalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonIkkeBetalt.Name = "radioButtonIkkeBetalt";
            this.radioButtonIkkeBetalt.Size = new System.Drawing.Size(105, 24);
            this.radioButtonIkkeBetalt.TabIndex = 10;
            this.radioButtonIkkeBetalt.TabStop = true;
            this.radioButtonIkkeBetalt.Text = "Ikke betalt";
            this.toolTip1.SetToolTip(this.radioButtonIkkeBetalt, "Vis kun fakturaer der ikke er betalt");
            this.radioButtonIkkeBetalt.UseVisualStyleBackColor = true;
            this.radioButtonIkkeBetalt.CheckedChanged += new System.EventHandler(this.radioButtonIkkeBetalt_CheckedChanged);
            // 
            // radioButtonAlle
            // 
            this.radioButtonAlle.AutoSize = true;
            this.radioButtonAlle.Location = new System.Drawing.Point(27, 50);
            this.radioButtonAlle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAlle.Name = "radioButtonAlle";
            this.radioButtonAlle.Size = new System.Drawing.Size(58, 24);
            this.radioButtonAlle.TabIndex = 1;
            this.radioButtonAlle.TabStop = true;
            this.radioButtonAlle.Text = "Alle";
            this.toolTip1.SetToolTip(this.radioButtonAlle, "Vis alle faktura");
            this.radioButtonAlle.UseVisualStyleBackColor = true;
            this.radioButtonAlle.CheckedChanged += new System.EventHandler(this.radioButtonAlle_CheckedChanged);
            // 
            // dataGridViewAlleFaktura
            // 
            this.dataGridViewAlleFaktura.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAlleFaktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlleFaktura.Location = new System.Drawing.Point(117, 89);
            this.dataGridViewAlleFaktura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAlleFaktura.Name = "dataGridViewAlleFaktura";
            this.dataGridViewAlleFaktura.RowHeadersWidth = 51;
            this.dataGridViewAlleFaktura.RowTemplate.Height = 24;
            this.dataGridViewAlleFaktura.Size = new System.Drawing.Size(600, 518);
            this.dataGridViewAlleFaktura.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGridViewAlleFaktura, "Alle fakturaer");
            this.dataGridViewAlleFaktura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlleFaktura_CellContentClick);
            this.dataGridViewAlleFaktura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlleFaktura_CellContentClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 51);
            this.label8.TabIndex = 10;
            this.label8.Text = "Faktura";
            // 
            // GUIFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1721, 881);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxAlleFaktura);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUIFaktura";
            this.Text = "Faktura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIFaktura_FormClosing_1);
            this.Load += new System.EventHandler(this.GUIFaktura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakturaLinjer)).EndInit();
            this.groupBoxAlleFaktura.ResumeLayout(false);
            this.groupBoxAlleFaktura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlleFaktura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBehandlingstype;
        private System.Windows.Forms.Label labelSalgsstype;
        private System.Windows.Forms.ComboBox comboBoxVarer;
        private System.Windows.Forms.Label labelMedicin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSøg;
        private System.Windows.Forms.TextBox textBoxFakturanummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFakturaLinjer;
        private System.Windows.Forms.Button buttonGem;
        private System.Windows.Forms.Button buttonTilføjTilFaktura;
        private System.Windows.Forms.Button buttonSletLinje;
        private System.Windows.Forms.GroupBox groupBoxAlleFaktura;
        private System.Windows.Forms.RadioButton radioButtonAlle;
        private System.Windows.Forms.DataGridView dataGridViewAlleFaktura;
        private System.Windows.Forms.RadioButton radioButtonBetalt;
        private System.Windows.Forms.RadioButton radioButtonIkkeBetalt;
        private System.Windows.Forms.Button buttonSøgEjer;
        private System.Windows.Forms.TextBox textBoxTlf;
        private System.Windows.Forms.RadioButton radioButtonErBetalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonErIkkeBetalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSletFaktura;
        private System.Windows.Forms.TextBox textBoxPris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAntal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrisIAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIAltPris;
        private System.Windows.Forms.NumericUpDown numericUpDownAntal;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRabat;
        public System.Windows.Forms.TextBox textBoxtelefonEjer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox textBoxNavn;
        private System.Windows.Forms.Label labelNavn;
        private System.Windows.Forms.Label label8;
    }
}