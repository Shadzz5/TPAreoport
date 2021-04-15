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
    public partial class AjoutModifSupprAvion : Form
    {

        public AjoutModifSupprAvion()
        {
            InitializeComponent();
            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
            ListAvion.ValueMember = "Identifiant";

            List<Modele> modele = AeroportBdd.AllModele();
            comboBoxModele.DataSource = modele;
            comboBoxModele.DisplayMember = "CompleteName";
            comboBoxModele.ValueMember = "Identifiant";

            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            comboBoxConst.DataSource = constructeurs;
            comboBoxConst.DisplayMember = "CompleteName";
            comboBoxConst.ValueMember = "Identifiant";



        }
        public void RefreshListBox()
        {
            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = null;
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
        }




        private void Ajouter_Click(object sender, EventArgs e)
        {
            Ajout form = new Ajout();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Voulez-vous supprimer", "Suppression", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Avion selectedAvion = (Avion)ListAvion.SelectedItem;
                int idavion = selectedAvion.Identifiant;
                AeroportBdd.DeleteAvion(idavion);
                RefreshListBox();
                ListAvion.SelectedIndex = ListAvion.Items.Count - 1;
            }
            if (result1 == DialogResult.No)
            {

            }

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voulez-vous modifier", "Modification", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Avion avion = (Avion)ListAvion.SelectedItem;
                avion.Nom = textBoxAvionNom.Text;
                avion.IdentifiantModele = ((Modele)comboBoxModele.SelectedItem).Identifiant;
                AeroportBdd.UpdateAvion(avion);
                RefreshListBox();
                ListAvion.SelectedValue = avion.Identifiant;
            }
            if (result1 == DialogResult.No)
            {

            }

        }

        private void comboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constructeur selectedConstructeur = (Constructeur)comboBoxConst.SelectedItem;
            comboBoxModele.DataSource = AeroportBdd.GetFromModele(((Constructeur)comboBoxConst.SelectedItem).Identifiant);
            comboBoxModele.DisplayMember = "CompleteName";
            comboBoxModele.ValueMember = "Identifiant";

        }

        private void ListAvion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListAvion.SelectedItem != null)
            {
                Avion selectedAvion = (Avion)ListAvion.SelectedItem;
                textBoxAvionNom.Text = selectedAvion.Nom;

                Modele selectedModele = AeroportBdd.GetModele(selectedAvion.IdentifiantModele);
                comboBoxModele.SelectedValue = selectedModele.Identifiant;

                Constructeur selectedConstructeur = AeroportBdd.GetConstruct(selectedModele.IdentifiantConstructeur);
                comboBoxConst.SelectedValue = selectedConstructeur.Identifiant;
            }
        }
    }
}
