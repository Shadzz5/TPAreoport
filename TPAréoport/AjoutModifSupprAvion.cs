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
            ListModele.DataSource = modele;
            ListModele.DisplayMember = "CompleteName";
            ListModele.ValueMember = "Identifiant";

            List<Constructeur> constr = AeroportBdd.AllConstruct();
            ListConstruc.DataSource = constr;
            ListConstruc.DisplayMember = "CompleteName";
            ListConstruc.ValueMember = "Identifiant";


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
           
           
           
        }
        private void ListModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modele selectedModele = (Modele)ListModele.SelectedItem;
            

        }

        private void ListConstruc_SelectedIndexChanged(object sender, EventArgs e)
        {

            Constructeur selectedConstruc = (Constructeur)ListConstruc.SelectedItem;
     
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Ajout form = new Ajout();
            form.ShowDialog();

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Avion selectedAvion = (Avion)ListAvion.SelectedItem;
            int idavion = selectedAvion.Identifiant;
            AeroportBdd.DeleteAvion(idavion);


            Modele selectedModele = (Modele)ListModele.SelectedItem;
            int idmodele = selectedModele.Identifiant;
            AeroportBdd.DeleteModele(idmodele);

            Constructeur selectedConstruc = (Constructeur)ListConstruc.SelectedItem;
            int idconstr = selectedConstruc.Identifiant;
            AeroportBdd.DeleteModele(idconstr);
            RefreshBooksListBox();
        }



        private void Modifier_Click(object sender, EventArgs e)
        {
            Modif form = new Modif();
            form.ShowDialog();
        }


    }
}
