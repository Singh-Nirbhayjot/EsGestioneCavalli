namespace EsGestioneCavalli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRazza = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.lstCavalli = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.rdbFemmina = new System.Windows.Forms.RadioButton();
            this.rdbMaschio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtRazza
            // 
            this.txtRazza.Location = new System.Drawing.Point(178, 48);
            this.txtRazza.Name = "txtRazza";
            this.txtRazza.Size = new System.Drawing.Size(100, 22);
            this.txtRazza.TabIndex = 1;
            this.txtRazza.TextChanged += new System.EventHandler(this.txtRazza_TextChanged);
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(25, 120);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(107, 22);
            this.txtAnno.TabIndex = 2;
            this.txtAnno.TextChanged += new System.EventHandler(this.txtAnno_TextChanged);
            // 
            // lstCavalli
            // 
            this.lstCavalli.FormattingEnabled = true;
            this.lstCavalli.ItemHeight = 16;
            this.lstCavalli.Location = new System.Drawing.Point(343, 19);
            this.lstCavalli.Name = "lstCavalli";
            this.lstCavalli.Size = new System.Drawing.Size(445, 420);
            this.lstCavalli.TabIndex = 4;
            this.lstCavalli.SelectedIndexChanged += new System.EventHandler(this.lstCavalli_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anno nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sesso";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(44, 176);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(72, 29);
            this.btnAggiungi.TabIndex = 9;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(193, 176);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(72, 29);
            this.btnModifica.TabIndex = 12;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(44, 242);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(72, 29);
            this.btnCerca.TabIndex = 13;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(193, 242);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(72, 29);
            this.btnRimuovi.TabIndex = 14;
            this.btnRimuovi.Text = "Rimuovi";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // rdbFemmina
            // 
            this.rdbFemmina.AutoSize = true;
            this.rdbFemmina.Location = new System.Drawing.Point(242, 122);
            this.rdbFemmina.Name = "rdbFemmina";
            this.rdbFemmina.Size = new System.Drawing.Size(36, 20);
            this.rdbFemmina.TabIndex = 11;
            this.rdbFemmina.TabStop = true;
            this.rdbFemmina.Text = "F";
            this.rdbFemmina.UseVisualStyleBackColor = true;
            this.rdbFemmina.CheckedChanged += new System.EventHandler(this.rdbFemmina_CheckedChanged);
            // 
            // rdbMaschio
            // 
            this.rdbMaschio.AutoSize = true;
            this.rdbMaschio.Location = new System.Drawing.Point(193, 122);
            this.rdbMaschio.Name = "rdbMaschio";
            this.rdbMaschio.Size = new System.Drawing.Size(39, 20);
            this.rdbMaschio.TabIndex = 10;
            this.rdbMaschio.TabStop = true;
            this.rdbMaschio.Text = "M";
            this.rdbMaschio.UseVisualStyleBackColor = true;
            this.rdbMaschio.CheckedChanged += new System.EventHandler(this.rdbMaschio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRimuovi);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.rdbFemmina);
            this.Controls.Add(this.rdbMaschio);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCavalli);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.txtRazza);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRazza;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.ListBox lstCavalli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.RadioButton rdbFemmina;
        private System.Windows.Forms.RadioButton rdbMaschio;
    }
}

