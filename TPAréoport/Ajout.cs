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
        public object Avion { get; internal set; }

        public Ajout()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
            Modele model = new Modele();
            Constructeur constructeur = new Constructeur();

         
            avion.Nom = NomAvion.Text;
            model.NombreDeMoteur = Int32.Parse(NombreMoteur.Text);
            model.Version = NomVersion.Text;
            constructeur.Nom = NomConstruc.Text;

            AeroportBdd.InsertAvion(avion);
            AeroportBdd.InsertConstruc(constructeur);
            AeroportBdd.InsertModele(model);
            DialogResult = DialogResult.OK;

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
