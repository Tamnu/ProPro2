using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

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
            try
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
                if (cbxStrike.Checked)
                {
                    stil = stil | FontStyle.Strikeout;
                }

                string teckensnittfråncombobox = comboBox1.SelectedItem.ToString();

                Font font = new Font(teckensnittfråncombobox, storlek, stil);
                tbxFörhandsgranskning.Font = font;
            }
            catch(Exception ex)
            {
                MessageBox.Show("OMG!Det gick inte!. \n\n" + ex.ToString());
            }
            InstalledFontCollection fonts = new InstalledFontCollection();
            FontFamily[] fontas = fonts.Families.ToArray();
            for (int i = 0; i < fontas.Length; i++)

            {

                //listBox1.Items.Add(fontas[i].Name);
                comboBox1.Items.Add(fontas[i].Name);

            }





        }

        private void uppdatera()
        {
            try
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
                if (cbxStrike.Checked)
                {
                    stil = stil | FontStyle.Strikeout;
                }

                string teckensnittfråncombobox = comboBox1.SelectedItem.ToString();

                Font font = new Font(teckensnittfråncombobox, storlek, stil);
                tbxFörhandsgranskning.Font = font;
            }
            catch (Exception ex)
            {
                MessageBox.Show("OMG!Det gick inte!. \n\n" + ex.ToString());
            }
            InstalledFontCollection fonts = new InstalledFontCollection();
            FontFamily[] fontas = fonts.Families.ToArray();
            for (int i = 0; i < fontas.Length; i++)

            {

                //listBox1.Items.Add(fontas[i].Name);
                comboBox1.Items.Add(fontas[i].Name);

            }

        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uppdatera();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CbxUnder_CheckedChanged(object sender, EventArgs e)
        {
            uppdatera();
        }

        private void CbxFet_CheckedChanged(object sender, EventArgs e)
        {
            uppdatera();
        }

        private void CbxKursiv_CheckedChanged(object sender, EventArgs e)
        {
            uppdatera();
        }

        private void CbxStrike_CheckedChanged(object sender, EventArgs e)
        {
            uppdatera();
        }
    }
}
