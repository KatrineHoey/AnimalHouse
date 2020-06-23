namespace GUI
{
    partial class GUIIndkaldelseTilKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIIndkaldelseTilKontrol));
            this.buttonHnetPatineter = new System.Windows.Forms.Button();
            this.buttonMail = new System.Windows.Forms.Button();
            this.buttonBrev = new System.Windows.Forms.Button();
            this.buttonKort = new System.Windows.Forms.Button();
            this.dataGridViewPatinter = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatinter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHnetPatineter
            // 
            this.buttonHnetPatineter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHnetPatineter.Location = new System.Drawing.Point(44, 38);
            this.buttonHnetPatineter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHnetPatineter.Name = "buttonHnetPatineter";
            this.buttonHnetPatineter.Size = new System.Drawing.Size(227, 36);
            this.buttonHnetPatineter.TabIndex = 1;
            this.buttonHnetPatineter.Text = "Hent patienter";
            this.toolTip1.SetToolTip(this.buttonHnetPatineter, "Henter patienter, der ikke har været til konsultation af deres dyr i et år");
            this.buttonHnetPatineter.UseVisualStyleBackColor = true;
            this.buttonHnetPatineter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMail
            // 
            this.buttonMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMail.Location = new System.Drawing.Point(1137, 38);
            this.buttonMail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(100, 36);
            this.buttonMail.TabIndex = 2;
            this.buttonMail.Text = "Mail";
            this.toolTip1.SetToolTip(this.buttonMail, "Udsend indkaldelse via mail");
            this.buttonMail.UseVisualStyleBackColor = true;
            // 
            // buttonBrev
            // 
            this.buttonBrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBrev.Location = new System.Drawing.Point(1245, 38);
            this.buttonBrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrev.Name = "buttonBrev";
            this.buttonBrev.Size = new System.Drawing.Size(100, 36);
            this.buttonBrev.TabIndex = 3;
            this.buttonBrev.Text = "Brev";
            this.toolTip1.SetToolTip(this.buttonBrev, "Udsend indkaldelse via brev");
            this.buttonBrev.UseVisualStyleBackColor = true;
            // 
            // buttonKort
            // 
            this.buttonKort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonKort.Location = new System.Drawing.Point(1029, 38);
            this.buttonKort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKort.Name = "buttonKort";
            this.buttonKort.Size = new System.Drawing.Size(100, 36);
            this.buttonKort.TabIndex = 4;
            this.buttonKort.Text = "Kort";
            this.toolTip1.SetToolTip(this.buttonKort, "Udsend indkaldelse som kort");
            this.buttonKort.UseVisualStyleBackColor = true;
            this.buttonKort.Click += new System.EventHandler(this.buttonKort_Click);
            // 
            // dataGridViewPatinter
            // 
            this.dataGridViewPatinter.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPatinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatinter.Location = new System.Drawing.Point(44, 93);
            this.dataGridViewPatinter.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatinter.Name = "dataGridViewPatinter";
            this.dataGridViewPatinter.RowHeadersWidth = 51;
            this.dataGridViewPatinter.Size = new System.Drawing.Size(1301, 465);
            this.dataGridViewPatinter.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHnetPatineter);
            this.groupBox1.Controls.Add(this.buttonMail);
            this.groupBox1.Controls.Add(this.buttonBrev);
            this.groupBox1.Controls.Add(this.buttonKort);
            this.groupBox1.Controls.Add(this.dataGridViewPatinter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1382, 597);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indkald til kontrol";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Indkald til kontrol";
            // 
            // IndkaldelseTilKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1595, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndkaldelseTilKontrol";
            this.Text = "Indkaldelse til Kontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndkaldelseTilKontrol_FormClosing);
            this.Load += new System.EventHandler(this.IndkaldelseTilKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatinter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHnetPatineter;
        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.Button buttonBrev;
        private System.Windows.Forms.Button buttonKort;
        private System.Windows.Forms.DataGridView dataGridViewPatinter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}