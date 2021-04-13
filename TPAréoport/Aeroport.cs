using Aeroport.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using TPAréoport;

namespace TPAreoport
{
    public partial class Avions : Form
    {
       
        
        public Avions()
        {
            InitializeComponent();
            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
            ListAvion.ValueMember = "Identifiant";

            List<Modele> modele = AeroportBdd.AllModele();
            ListModele.DataSource = modele;
            ListModele.DisplayMember = "CompleteName";
            ListModele.ValueMember = "Identifiant";

            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            ListConstructeur.DataSource = constructeurs;
            ListConstructeur.DisplayMember = "CompleteName";
            ListConstructeur.ValueMember = "Identifiant";

        }

        public void RefreshBooksListBox()
        {
            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = null;
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
        }

        private void ListAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Avion selectedAvion = (Avion)ListAvion.SelectedItem;
            int idmodele = selectedAvion.IdentifiantModele;
            Modele model = AeroportBdd.GetModele(idmodele);
            int idconstruc = model.IdentifiantConstructeur;
            Constructeur constr = AeroportBdd.GetConstruct(idconstruc);
            ResultNom.Text = selectedAvion.Nom;
            ResultVersion.Text = model.Version;
            ResultMoteur.Text = model.NombreDeMoteur.ToString();
            ResultConstructeur.Text = constr.Nom; 
            
        }

        private void ListModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modele selectedModele = (Modele)ListModele.SelectedItem;
            

        }

        private void ListConstructeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constructeur selectedConstructeur = (Constructeur)ListConstructeur.SelectedItem;
            

        }

        private void ButtonAvion_Click(object sender, EventArgs e)
        {
            AjoutModifSupprAvion form = new AjoutModifSupprAvion();
            form.ShowDialog();
        }
    }
}

