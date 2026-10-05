using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculategutton_Click(object sender, EventArgs e)
        {
            try
            {
                double hours = double.Parse(hoursworkedtextbox.Text);
                double rate = double.Parse(hourlypayratetextbox.Text);
                double grossPay;

                if (hours >= 0)
                {
                    if (rate > 0)
                    {
                        if (hours <= 40)
                        {
                            grossPay = hours * rate;
                        }
                        else
                        {
                            double regularPay = 40 * rate;
                            double overtimeHours = hours - 40;
                            double overtimePay = overtimeHours * rate * 1.5;

                            grossPay = regularPay + overtimePay;
                        }

                        grosspayble.Text = grossPay.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Pay rate must be greater than 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Hours cannot be negative.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            hoursworkedtextbox.Clear();
            hourlypayratetextbox.Clear();
            calculategutton.Text = "";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

