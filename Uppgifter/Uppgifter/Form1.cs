using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgifter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int storlek = int.Parse(tbxStorlek.Text);
            FontStyle stil = FontStyle.Regular;
            if (cbxFet.Checked)
            {
                stil = stil | FontStyle.Bold;
            }
            if (cbxKursiv.Checked)
            {
                stil = stil | FontStyle.Italic;
            }
            if (cbxUnder.Checked)
            {
                stil = stil | FontStyle.Underline;
            }
            Font font = new Font(tbxTeckensnitt.Text, storlek, stil);
            tbxFörhandsgranskning.Font = font;
        }
    }
}
