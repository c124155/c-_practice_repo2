using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncheack_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtchek.Text);

                if (number >= 1 && number <= 10)
                {
                    lbloutput.Text = "Number wu katirsanyhy rang.";
                }
                else
                {
                    lbloutput.Text = "Number kama tirsano rang.";
                }
            }
            catch
            {
                MessageBox.Show("Please sokali integer.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtchek.Clear();
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

