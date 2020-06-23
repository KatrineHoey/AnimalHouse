namespace GUI
{
    partial class GUIMedicinpriser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIMedicinpriser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNomeco = new System.Windows.Forms.Button();
            this.buttonOpdaterePriser = new System.Windows.Forms.Button();
            this.buttonNova = new System.Windows.Forms.Button();
            this.listViewMedicin = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNomeco);
            this.groupBox1.Controls.Add(this.buttonOpdaterePriser);
            this.groupBox1.Controls.Add(this.buttonNova);
            this.groupBox1.Controls.Add(this.listViewMedicin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tilføj medicinpriser";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonNomeco
            // 
            this.buttonNomeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNomeco.Location = new System.Drawing.Point(6, 66);
            this.buttonNomeco.Name = "buttonNomeco";
            this.buttonNomeco.Size = new System.Drawing.Size(179, 29);
            this.buttonNomeco.TabIndex = 8;
            this.buttonNomeco.Text = "Hent Nomeco priser";
            this.toolTip1.SetToolTip(this.buttonNomeco, "Hent medicinpriser fra Nomeco");
            this.buttonNomeco.UseVisualStyleBackColor = true;
            this.buttonNomeco.Click += new System.EventHandler(this.buttonNomeco_Click);
            // 
            // buttonOpdaterePriser
            // 
            this.buttonOpdaterePriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpdaterePriser.Location = new System.Drawing.Point(577, 418);
            this.buttonOpdaterePriser.Name = "buttonOpdaterePriser";
            this.buttonOpdaterePriser.Size = new System.Drawing.Size(180, 29);
            this.buttonOpdaterePriser.TabIndex = 5;
            this.buttonOpdaterePriser.Text = "Opdater priserne";
            this.toolTip1.SetToolTip(this.buttonOpdaterePriser, "Opdater medicinpriserne i databasen");
            this.buttonOpdaterePriser.UseVisualStyleBackColor = true;
            this.buttonOpdaterePriser.Click += new System.EventHandler(this.buttonOpdaterePriser_Click);
            // 
            // buttonNova
            // 
            this.buttonNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNova.Location = new System.Drawing.Point(6, 30);
            this.buttonNova.Name = "buttonNova";
            this.buttonNova.Size = new System.Drawing.Size(179, 29);
            this.buttonNova.TabIndex = 4;
            this.buttonNova.Text = "Hent Nova priser";
            this.toolTip1.SetToolTip(this.buttonNova, "Hent medicinpriser fra Novo");
            this.buttonNova.UseVisualStyleBackColor = true;
            this.buttonNova.Click += new System.EventHandler(this.buttonHentMedicin_Click);
            // 
            // listViewMedicin
            // 
            this.listViewMedicin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewMedicin.HideSelection = false;
            this.listViewMedicin.Location = new System.Drawing.Point(208, 30);
            this.listViewMedicin.Name = "listViewMedicin";
            this.listViewMedicin.Size = new System.Drawing.Size(550, 374);
            this.listViewMedicin.TabIndex = 1;
            this.listViewMedicin.UseCompatibleStateImageBehavior = false;
            this.listViewMedicin.SelectedIndexChanged += new System.EventHandler(this.listViewMedicin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicinpriser";
            // 
            // GUIMedicinpriser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIMedicinpriser";
            this.Text = "Medicinpriser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIMedicinpriser_FormClosing);
            this.Load += new System.EventHandler(this.GUIMedicinpriser_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewMedicin;
        private System.Windows.Forms.Button buttonOpdaterePriser;
        private System.Windows.Forms.Button buttonNova;
        private System.Windows.Forms.Button buttonNomeco;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}