using Aeroport.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAréoport
{
    public partial class Ajout : Form
    {
        public object Avion { get; internal set; }

        public Ajout()
        {
            InitializeComponent();

            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            comboBoxConstructeur.DataSource = constructeurs;
            comboBoxConstructeur.DisplayMember = "CompleteName";
            comboBoxConstructeur.ValueMember = "Identifiant";
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

            if (NomAvion.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom");
            }
            else
            {
                Avion avion = new Avion();
                avion.Nom = NomAvion.Text;
                avion.IdentifiantModele = ((Modele)comboBoxVersion.SelectedItem).Identifiant;
                AeroportBdd.InsertAvion(avion);
                DialogResult = DialogResult.OK;

            }


        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modele selectedModele = (Modele)comboBoxVersion.SelectedItem;

            comboBoxVersion.SelectedItem = selectedModele.Version;




        }

        private void comboBoxConstructeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constructeur selectedConstructeur = (Constructeur)comboBoxConstructeur.SelectedItem;

            comboBoxConstructeur.SelectedItem = selectedConstructeur.Nom;
            comboBoxVersion.DataSource = AeroportBdd.GetFromModele(((Constructeur)comboBoxConstructeur.SelectedItem).Identifiant);
            comboBoxVersion.DisplayMember = "CompleteName";
            comboBoxVersion.ValueMember = "Identifiant";

        }


    }
}
