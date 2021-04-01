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
            listBox3.DataSource = avions;
            listBox3.DisplayMember = "CompleteName";
            listBox3.ValueMember = "Identifiant";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
                Avion selectedBook = (Avion)listBox3.SelectedItem;
                
               



        }
    }
}

