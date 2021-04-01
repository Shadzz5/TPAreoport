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
        private List<Avion> avions;
        public Aeroport()
        {
            InitializeComponent();
            List<Avion> avions = AeroportBdd.AllAvion();
            ListAvion.DataSource = avions;
            ListAvion.DisplayMember = "CompleteName";
            ListAvion.ValueMember = "Identifiant";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avion selectedBook = (Avion)ListAvion.SelectedItem;
            ListAvion.Items.Add(selectedBook);
        }
    }
}

