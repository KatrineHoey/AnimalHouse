namespace GUI
{
    partial class GUILagerStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUILagerStatus));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrintListe = new System.Windows.Forms.Button();
            this.textBoxSamletIndkøbspris = new System.Windows.Forms.TextBox();
            this.buttonSelavstatus = new System.Windows.Forms.Button();
            this.buttonLagerVare = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxLagerstatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxLagerstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonPrintListe
            // 
            this.buttonPrintListe.Location = new System.Drawing.Point(336, 463);
            this.buttonPrintListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrintListe.Name = "buttonPrintListe";
            this.buttonPrintListe.Size = new System.Drawing.Size(122, 36);
            this.buttonPrintListe.TabIndex = 1;
            this.buttonPrintListe.Text = "Print Liste";
            this.toolTip1.SetToolTip(this.buttonPrintListe, "Print en liste i et tekst dokument, over lager status");
            this.buttonPrintListe.UseVisualStyleBackColor = true;
            this.buttonPrintListe.Click += new System.EventHandler(this.buttonPrintListe_Click);
            // 
            // textBoxSamletIndkøbspris
            // 
            this.textBoxSamletIndkøbspris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSamletIndkøbspris.Location = new System.Drawing.Point(1101, 464);
            this.textBoxSamletIndkøbspris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSamletIndkøbspris.Name = "textBoxSamletIndkøbspris";
            this.textBoxSamletIndkøbspris.Size = new System.Drawing.Size(130, 30);
            this.textBoxSamletIndkøbspris.TabIndex = 3;
            this.textBoxSamletIndkøbspris.TextChanged += new System.EventHandler(this.textBoxSamletIndkøbspris_TextChanged);
            // 
            // buttonSelavstatus
            // 
            this.buttonSelavstatus.Location = new System.Drawing.Point(186, 463);
            this.buttonSelavstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelavstatus.Name = "buttonSelavstatus";
            this.buttonSelavstatus.Size = new System.Drawing.Size(122, 36);
            this.buttonSelavstatus.TabIndex = 4;
            this.buttonSelavstatus.Text = "Se lav status";
            this.toolTip1.SetToolTip(this.buttonSelavstatus, "Viser alle vare med et antal under 10 stk");
            this.buttonSelavstatus.UseVisualStyleBackColor = true;
            this.buttonSelavstatus.Click += new System.EventHandler(this.buttonSelavstatus_Click);
            // 
            // buttonLagerVare
            // 
            this.buttonLagerVare.Location = new System.Drawing.Point(31, 463);
            this.buttonLagerVare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLagerVare.Name = "buttonLagerVare";
            this.buttonLagerVare.Size = new System.Drawing.Size(122, 36);
            this.buttonLagerVare.TabIndex = 5;
            this.buttonLagerVare.Text = "Antal vare";
            this.toolTip1.SetToolTip(this.buttonLagerVare, "Viser status over alle vare");
            this.buttonLagerVare.UseVisualStyleBackColor = true;
            this.buttonLagerVare.Click += new System.EventHandler(this.buttonLagerVare_Click);
            // 
            // groupBoxLagerstatus
            // 
            this.groupBoxLagerstatus.Controls.Add(this.label2);
            this.groupBoxLagerstatus.Controls.Add(this.dataGridView1);
            this.groupBoxLagerstatus.Controls.Add(this.buttonPrintListe);
            this.groupBoxLagerstatus.Controls.Add(this.buttonSelavstatus);
            this.groupBoxLagerstatus.Controls.Add(this.buttonLagerVare);
            this.groupBoxLagerstatus.Controls.Add(this.textBoxSamletIndkøbspris);
            this.groupBoxLagerstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLagerstatus.Location = new System.Drawing.Point(36, 128);
            this.groupBoxLagerstatus.Name = "groupBoxLagerstatus";
            this.groupBoxLagerstatus.Size = new System.Drawing.Size(1282, 535);
            this.groupBoxLagerstatus.TabIndex = 7;
            this.groupBoxLagerstatus.TabStop = false;
            this.groupBoxLagerstatus.Text = "Lagerstatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lagerstatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Samlet indkøbspris";
            // 
            // GUILagerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1484, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxLagerstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUILagerStatus";
            this.Text = "Lagerstatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUILagerStatus_FormClosing);
            this.Load += new System.EventHandler(this.GUILagerStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxLagerstatus.ResumeLayout(false);
            this.groupBoxLagerstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrintListe;
        private System.Windows.Forms.TextBox textBoxSamletIndkøbspris;
        private System.Windows.Forms.Button buttonSelavstatus;
        private System.Windows.Forms.Button buttonLagerVare;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxLagerstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}