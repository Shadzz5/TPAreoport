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
    public partial class Aeroport : Form
    {
       
        
        public Aeroport()
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
            int idmodele = selectedAvion.IdentifiantModele;
            Modele model = AeroportBdd.GetModele(idmodele);
            int idconstruc = model.IdentifiantConstructeur;
            Constructeur constr = AeroportBdd.GetConstruct(idconstruc);
            ResultNom.Text = selectedAvion.Nom;
            ResultVersion.Text = model.Version;
            ResultMoteur.Text = model.NombreDeMoteur.ToString();
            ResultConstructeur.Text = constr.Nom; 
            
        }
      

        private void ButtonAvion_Click(object sender, EventArgs e)
        {
            AjoutModifSupprAvion form = new AjoutModifSupprAvion();
            form.ShowDialog();
           
        }
    }
}

