using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_shala
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

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

    
            private void btnCalculate_Click(object sender, EventArgs e)
        {
            int packages;
            double price;

            if (!int.TryParse(txtpackage.Text, out packages) ||
                !double.TryParse(txtprice.Text, out price) ||
                packages <= 0 || price <= 0)
            {
                MessageBox.Show("Please enter correct values");
                return;
            }

            double subtotal = packages * price;
            double discountRate;

            if (packages >= 100)
                discountRate = 0.50;
            else if (packages >= 50)
                discountRate = 0.40;
            else if (packages >= 20)
                discountRate = 0.30;
            else if (packages >= 10)
                discountRate = 0.20;
            else
                discountRate = 0.0;

            double discount = subtotal * discountRate;
            double total = subtotal - discount;

            lstresult.Items.Clear();
            lstresult.Items.Add("Purchase Results");
            lstresult.Items.Add("Number of Packages: " + packages);
            lstresult.Items.Add("Price per Package: " + price.ToString("C2"));
            lstresult.Items.Add("Subtotal: " + subtotal.ToString("C2"));
            lstresult.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
            lstresult.Items.Add("Discount Amount: " + discount.ToString("C2"));
            lstresult.Items.Add("Total Amount: " + total.ToString("C2"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpackage.Clear();
            txtprice.Clear();
            lstresult.Items.Clear();
            txtpackage.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    
    }
    }

