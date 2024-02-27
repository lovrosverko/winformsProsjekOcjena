using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsjekOcjena
{
    public partial class Form1 : Form
    {
        int ocjena, brojOcjena = 0, zbroj = 0;
        double prosjek;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(txtUnosOcjene.Text);
            brojOcjena++;
            zbroj += ocjena;
            DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (odgovor){
                case DialogResult.Yes:
                    txtUnosOcjene.Clear();
                    txtUnosOcjene.Focus();
                    break;
                case DialogResult.No:
                    prosjek = (double)zbroj / brojOcjena;
                    txtProsjek.Text = prosjek.ToString();
                    break;
            }
        }
    }
}
