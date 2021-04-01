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


            List<Constructeur> constructeurs = AeroportBdd.AllConstruct();
            ListboxConstructeur.DataSource = constructeurs;
            ListboxConstructeur.DisplayMember = "CompleteName";
            ListboxConstructeur.ValueMember = "Identifiant";

            List<Modele> modeles = AeroportBdd.AllModele();
            ListModele.DataSource = modeles;
            ListModele.DisplayMember = "CompleteName";
            ListModele.ValueMember = "Identifiant";
        }

        private void ListboxConstructeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constructeur selectedConstructeur = (Constructeur)ListboxConstructeur.SelectedItem;
        }

        private void ListAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avion selectedAvion = (Avion)ListAvion.SelectedItem;
           
        }

        private void ListModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modele selectedModele = (Modele)ListModele.SelectedItem;
        }
    }
}

