using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Träning
{
    public partial class Form1 : Form
    {
        List<Logg> logglist = new List<Logg>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int sträcka = int.Parse(tbxSträcka.Text);
            int tid = int.Parse(tbxTid.Text);
            Logg träning = new Logg(sträcka, tid);
            logglist.Add(träning);
            tbxSträcka.Clear();
            tbxTid.Clear();
        }

        private void BtnAlla_Click(object sender, EventArgs e)
        {
            int sök = int.Parse(tbxSök.Text);
            foreach(Logg s in logglist)
            {
                if (s.tid > sök)
                {
                    lbxVisa.Items.Add(s);
                }
            }
        }

        private void BtnNågra_Click(object sender, EventArgs e)
        {

        }
    }
}
