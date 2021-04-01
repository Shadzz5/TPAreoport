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
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
            avion.Nom = this.NomAvion.Text;
            AeroportBdd.InsertAvion(avion);
            DialogResult = DialogResult.OK;
        }
    }
}
