using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tavling
{
    public partial class Form1 : Form
    {
        Score[] scores = new Score[100];

        int räkna = 0;

        //List<Score> scoreList = new List<Score>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            int poäng = int.Parse(tbxPoint.Text);

            Score spelare = new Score(namn, poäng);

            scores[räkna++] = spelare;
            //scoreList.Add(spelare);

            MessageBox.Show("Resultat registrerat", "klart", MessageBoxButtons. OK, MessageBoxIcon.Information);
            tbxNamn.Clear();
            tbxPoint.Clear();
            lbxVisa.Items.Add(spelare);

            
        }

        private void BtnVisa_Click(object sender, EventArgs e)
        {
            lbxVisa.Items.Clear();
            int check = int.Parse(textBox3.Text);
            for (int i=0; i < räkna; i++)
            {
                if (scores[i].points > check)
                {
                    lbxVisa.Items.Add(scores[i]);
                }                
            }

            //foreach(Score s in scoreList)
            //{
            //    if (s.points > check)
            //    {
            //        lbxVisa.Items.Add(s);
            //    }
            //}
           
        }
    }
}
