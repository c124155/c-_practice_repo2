using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avrage_displayed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculte_Click(object sender, EventArgs e)
        {
            double score1, score2, score3 ,avrg;
            try
            {
                score1 = double.Parse(txtscorestar.Text);
                score2 = double.Parse(txtscoretwo.Text);
                score3 = double.Parse(txtscoreend.Text);

                avrg = (score1 + score2 + score3) / 3;
                lblCLCULTEAR.Text =avrg.ToString ();
                if (avrg >= 90)
                {
                    MessageBox.Show("grade A");

                }
                else if (avrg >= 80)
                {
                    MessageBox.Show("GRADE B");

                }
                else if (avrg >= 70)
                {
                    MessageBox.Show("GRADE C");
                }
                else if (avrg >= 60) 
                {
                    MessageBox.Show("GRADE D");
                }
                else
                {
                    MessageBox.Show("GRADE F");
                }
         

               

            }
            catch
            {
                MessageBox.Show("pleas sokali sax number");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscorestar.Clear();
            txtscoretwo.Clear();
            txtscoreend.Clear();
            lblCLCULTEAR.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
