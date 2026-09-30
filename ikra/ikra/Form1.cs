using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {

                string guestname = txtguestname.Text;
                string roomtype = txtroomtype.Text;
                int night = int.Parse(txtnights.Text);

                double pricepernight = double.Parse(txtprice.Text);
                double subtotal = pricepernight * night;
                double servicetex = subtotal * 0.10;
                double discount = subtotal * 0.05;
                double total = subtotal + servicetex + discount;
                lblservestax.Text = servicetex.ToString("c2");
                lbldiscount.Text = discount.ToString("c2");
                lbltotalamount.Text = total.ToString("c2");
            }
            catch
            {
                MessageBox.Show("pleas wax sax  sokali");
            }
        }

        private void xtguestname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
