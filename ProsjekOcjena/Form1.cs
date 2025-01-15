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
            try
            {
                
                ocjena = Convert.ToInt32(txtUnosOcjene.Text);
                if (ocjena == 1)
                {
                    MessageBox.Show("Imaš negativnu ocjenu, ispravi je prije nego " +
                        "ideš računati prosjek!", "NEGATIVNO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else if (ocjena <= 0 || ocjena > 5)
                {
                    MessageBox.Show("Ocjena ne može biti nula ili manja od nule!", "Pogrešan unos!", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
                else
                {
                    brojOcjena++;
                    zbroj += ocjena;
                    
                    DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (odgovor)
                    {
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
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
    }
}
