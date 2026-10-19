using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               
                string guestName = txtName.Text;
                int guestAge = int.Parse(txtAge.Text);
                int numberOfNights = int.Parse(txtNights.Text);
                int numberOfGuests = int.Parse(txtguests.Text);

                double roomRate = 0;

                
                if (radStandard.Checked)
                {
                    roomRate = 50; 
                }
                else if (radNormal.Checked)
                {
                    roomRate = 80; 
                }
                else if (radHigh.Checked)
                {
                    roomRate = 120; 
                }

                
                double totalRoomCost = roomRate * numberOfNights * numberOfGuests;
                double breakfastCost = 0;

                if (chkBreakfast.Checked)
                {
                    breakfastCost = 10 * numberOfGuests * numberOfNights; 
                }

                double grandTotal = totalRoomCost + breakfastCost;

                listBox1.Items.Clear();
                listBox1.Items.Add("=== FAAFHIN BIXINTA ===");
                listBox1.Items.Add("Magaca: " + guestName);
                listBox1.Items.Add("Da'da: " + guestAge);
                listBox1.Items.Add("Habeenada: " + numberOfNights);
                listBox1.Items.Add("Tirada Martida: " + numberOfGuests);
                listBox1.Items.Add("Qiimaha Qolka: $" + totalRoomCost);

                if (chkBreakfast.Checked)
                {
                    listBox1.Items.Add("Qiimaha Quraacda: $" + breakfastCost);
                }

                listBox1.Items.Add("-----------------------------");
                listBox1.Items.Add("Wadarta Guud: $" + grandTotal);
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Fadlan da'da, tirada habeenada, iyo tirada martida ku qor tirooyin sax ah!", "Khalad Gelin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Digniin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtguests.Clear();

          
            radStandard.Checked = false;
            radNormal.Checked = false;
            radHigh.Checked = false;
            chkBreakfast.Checked = false;

           
            listBox1.Items.Clear();


            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    


    

