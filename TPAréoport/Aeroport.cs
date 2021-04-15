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

        #region Avion

        
        public Avions()
        {

            InitializeComponent();

            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
            ListAvion.ValueMember = "Identifiant";

        }
        #endregion
        #region RefreshListBox
        public void RefreshListBox()
        {
            List<Avion> avions = AeroportBdd.AllAvion();
            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            ListAvion.DataSource = null;
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";

        }
        #endregion
        #region ListAvion

        
        private void ListAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListAvion.SelectedItem != null)
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


        }
        #endregion
        #region ButtonAvion
 private void ButtonAvion_Click(object sender, EventArgs e)
        {
            AjoutModifSupprAvion form = new AjoutModifSupprAvion();
            form.ShowDialog();
            RefreshListBox();

        }
        #endregion
       
    }
}

