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
    public partial class Ajout : Form
    {


        public Ajout()
        {
            InitializeComponent();
            List<Modele> modele = AeroportBdd.AllModele();
            comboBoxVersion.DataSource = modele;
            comboBoxVersion.DisplayMember = "CompleteName";
            comboBoxVersion.ValueMember = "Identifiant";
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
            Modele model = new Modele();
            Constructeur constructeur = new Constructeur();
            int idmodele = avion.IdentifiantModele;
            int idconstruc = model.IdentifiantConstructeur;
            avion.Nom = this.NomAvion.Text;
            model.NombreDeMoteur = Int32.Parse(NombreMoteur.Text);
            Modele selectedModele = (Modele)comboBoxVersion.SelectedItem;
            

            constructeur.Nom = this.NomConstruc.Text;
            AeroportBdd.InsertAvion(avion);
            AeroportBdd.InsertConstruc(constructeur);
            AeroportBdd.InsertModele(model);
            DialogResult = DialogResult.OK;
        }
    }
}
