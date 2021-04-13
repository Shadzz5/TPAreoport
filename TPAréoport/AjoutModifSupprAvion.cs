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

            RefreshBooksListBox();
        }



        private void Modifier_Click(object sender, EventArgs e)
        {
            ModifAvion form = new ModifAvion();
            form.ShowDialog();
        }


    }
}
