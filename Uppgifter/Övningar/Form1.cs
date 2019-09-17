using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övningar
{
    public partial class Form1 : Form
    {
        int Antalbokningar = 0;
        Resor[] resa = new Resor[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBoka_Click(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            string destination = tbxDestination.Text;
            int dagar = int.Parse(tbxDagar.Text);
            Resor nyResa = new Resor(kund, destination, dagar);
            resa[Antalbokningar] = nyResa;
            Antalbokningar++;

            MessageBox.Show("Du har bokat", "OOO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lbxVisa.Items.Add(nyResa);
            tbxDagar.Text = "";
            tbxDestination.Text = "";
            tbxKund.Text = "";
        }
    }
}
