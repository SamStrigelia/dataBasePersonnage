using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBasePersonnages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Masquer les contrôles liés aux attributs spécifiques au chargement du formulaire
            lblPouvoir.Visible = false;
            cmbPouvoir.Visible = false;
            lblVie.Visible = false;
            nudVie.Visible = false;

            // Initialiser la ComboBox avec des pouvoirs
            cmbPouvoir.Items.Add("Vol");
            cmbPouvoir.Items.Add("Force surhumaine");
            cmbPouvoir.Items.Add("Télépathie");
        }

        #region Classes Personnage, Humain et Xmen

        public abstract class Personnage
        {
            // Propriétés
            protected string login = "inconnu";

            /**
             * constructeur simple (inconnu)
             */
            public Personnage()
            {
            }

            /**
             * constructeur pour initialiser le login
             */
            public Personnage(string login)
            {
                this.login = login;
            }

            /**
             * permet de retourner les informations du personnage
             */
            public abstract string info();

        }


        public class Humain : Personnage
        {
            // Propriétés
            private int vie;

            /**
             * constructeur initialise la vie
             */
            public Humain(int vie)
            {
                this.vie = vie;
            }

            /**
             * constructeur initialise le login et la vie
             */
            public Humain(string login, int vie) : base(login)
            {
                this.vie = vie;
            }

            /**
             * retourne le login et la vie
             */
            public override string info()
            {
                return "Humain : " + login + " (" + vie + ")";
            }
        }

        public class Xmen : Personnage
        {
            // Propriétés
            private string pouvoir;

            /**
             * constructeur initialise le pouvoir
             */
            public Xmen(string pouvoir)
            {
                this.pouvoir = pouvoir;
            }

            /**
             * constructeur initialise le login et le pouvoir
             */
            public Xmen(string login, string pouvoir) : base(login)
            {
                this.pouvoir = pouvoir;
            }

            /**
             * retourne le login et le pouvoir
             */
            public override string info()
            {
                return "Xmen : " + login + " (" + pouvoir + ")";
            }
        }

        #endregion
        #region RadioButton

        private void radHumain_CheckedChanged(object sender, EventArgs e)
        {
            if (radHumain.Checked)
            {
                // Afficher les contrôles liés aux Humains
                lblVie.Visible = true;
                nudVie.Visible = true;
                
                // Masquer les contrôles liés aux Xmen
                lblPouvoir.Visible = false;
                cmbPouvoir.Visible = false;
            }
        }

        private void radXMen_CheckedChanged(object sender, EventArgs e)
        {
            if (radXMen.Checked)
            {
                // Afficher les contrôles liés aux Xmen
                lblPouvoir.Visible = true;
                cmbPouvoir.Visible = true;

                // Masquer les contrôles liés aux Humains
                lblVie.Visible = false;
                nudVie.Visible = false;
            }
        }

        #endregion
    }
}
