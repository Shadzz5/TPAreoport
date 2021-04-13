using Aeroport.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAréoport
{
    public partial class ModifAvion : Form
    {
        public ModifAvion()
        {
            InitializeComponent();

            List<Avion> avions = AeroportBdd.AllAvion();
           
            List<Modele> modele = AeroportBdd.AllModele();
            comboBoxVersion.DataSource = modele;
            comboBoxVersion.DisplayMember = "CompleteName";
            comboBoxVersion.ValueMember = "Identifiant";



            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            comboBoxConstructeur.DataSource = constructeurs;
            comboBoxConstructeur.DisplayMember = "CompleteName";
            comboBoxConstructeur.ValueMember = "Identifiant";
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

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
        }

        private void NomAvion_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
