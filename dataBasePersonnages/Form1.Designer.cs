namespace dataBasePersonnages
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbPersonnage = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nudVie = new System.Windows.Forms.NumericUpDown();
            this.lblVie = new System.Windows.Forms.Label();
            this.radXMen = new System.Windows.Forms.RadioButton();
            this.radHumain = new System.Windows.Forms.RadioButton();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cmbPouvoir = new System.Windows.Forms.ComboBox();
            this.lblPouvoir = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lstPersonnage = new System.Windows.Forms.ListBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gpbPersonnage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPersonnage
            // 
            this.gpbPersonnage.Controls.Add(this.btnAjouter);
            this.gpbPersonnage.Controls.Add(this.nudVie);
            this.gpbPersonnage.Controls.Add(this.lblVie);
            this.gpbPersonnage.Controls.Add(this.radXMen);
            this.gpbPersonnage.Controls.Add(this.radHumain);
            this.gpbPersonnage.Controls.Add(this.txtLogin);
            this.gpbPersonnage.Controls.Add(this.cmbPouvoir);
            this.gpbPersonnage.Controls.Add(this.lblPouvoir);
            this.gpbPersonnage.Controls.Add(this.lblLogin);
            this.gpbPersonnage.Location = new System.Drawing.Point(12, 12);
            this.gpbPersonnage.Name = "gpbPersonnage";
            this.gpbPersonnage.Size = new System.Drawing.Size(414, 161);
            this.gpbPersonnage.TabIndex = 0;
            this.gpbPersonnage.TabStop = false;
            this.gpbPersonnage.Text = "Créer un Personnage :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(322, 103);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 52);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nudVie
            // 
            this.nudVie.Location = new System.Drawing.Point(83, 106);
            this.nudVie.Name = "nudVie";
            this.nudVie.Size = new System.Drawing.Size(68, 26);
            this.nudVie.TabIndex = 8;
            this.nudVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(6, 108);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(36, 20);
            this.lblVie.TabIndex = 7;
            this.lblVie.Text = "vie :";
            // 
            // radXMen
            // 
            this.radXMen.AutoSize = true;
            this.radXMen.Location = new System.Drawing.Point(322, 73);
            this.radXMen.Name = "radXMen";
            this.radXMen.Size = new System.Drawing.Size(77, 24);
            this.radXMen.TabIndex = 6;
            this.radXMen.TabStop = true;
            this.radXMen.Text = "x-men";
            this.radXMen.UseVisualStyleBackColor = true;
            this.radXMen.CheckedChanged += new System.EventHandler(this.radXMen_CheckedChanged);
            // 
            // radHumain
            // 
            this.radHumain.AutoSize = true;
            this.radHumain.Location = new System.Drawing.Point(322, 42);
            this.radHumain.Name = "radHumain";
            this.radHumain.Size = new System.Drawing.Size(86, 24);
            this.radHumain.TabIndex = 5;
            this.radHumain.TabStop = true;
            this.radHumain.Text = "humain";
            this.radHumain.UseVisualStyleBackColor = true;
            this.radHumain.CheckedChanged += new System.EventHandler(this.radHumain_CheckedChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(83, 41);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(215, 26);
            this.txtLogin.TabIndex = 4;
            // 
            // cmbPouvoir
            // 
            this.cmbPouvoir.FormattingEnabled = true;
            this.cmbPouvoir.Location = new System.Drawing.Point(83, 72);
            this.cmbPouvoir.Name = "cmbPouvoir";
            this.cmbPouvoir.Size = new System.Drawing.Size(215, 28);
            this.cmbPouvoir.TabIndex = 3;
            // 
            // lblPouvoir
            // 
            this.lblPouvoir.AutoSize = true;
            this.lblPouvoir.Location = new System.Drawing.Point(6, 75);
            this.lblPouvoir.Name = "lblPouvoir";
            this.lblPouvoir.Size = new System.Drawing.Size(68, 20);
            this.lblPouvoir.TabIndex = 2;
            this.lblPouvoir.Text = "pouvoir :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(50, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "login :";
            // 
            // lstPersonnage
            // 
            this.lstPersonnage.FormattingEnabled = true;
            this.lstPersonnage.ItemHeight = 20;
            this.lstPersonnage.Location = new System.Drawing.Point(12, 179);
            this.lstPersonnage.Name = "lstPersonnage";
            this.lstPersonnage.Size = new System.Drawing.Size(414, 364);
            this.lstPersonnage.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 555);
            this.Controls.Add(this.lstPersonnage);
            this.Controls.Add(this.gpbPersonnage);
            this.Name = "Form1";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbPersonnage.ResumeLayout(false);
            this.gpbPersonnage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPersonnage;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox cmbPouvoir;
        private System.Windows.Forms.Label lblPouvoir;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ListBox lstPersonnage;
        private System.Windows.Forms.RadioButton radXMen;
        private System.Windows.Forms.RadioButton radHumain;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.NumericUpDown nudVie;
        private System.Windows.Forms.Label lblVie;
    }
}

