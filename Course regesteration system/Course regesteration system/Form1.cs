using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_regesteration_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string name = txttransportation.Text;
            int age = int.Parse(txtid.Text);
            int number_of_courses = int.Parse(txtcourses.Text);
            int study_level = int.Parse(txtlevel.Text);


            // 1
            if ( int.TryParse(txtlevel.Text, out number_of_courses)){

            } else
            {
                MessageBox.Show("courses excepts numeric");
            }

            // 2
            if (number_of_courses >= 1 && number_of_courses <= 8)
            {

            }


            try
            {
                // Get student information
                string studentName = txtname.Text;
                int studentID = int.Parse(txtid.Text);
                int courseCount = int.Parse(txtcourses.Text);
                int studyYear = int.Parse(txtlevel.Text);
                double transportFee = int.Parse(txttransport.Text);

                double tuitionFee = 0;
                double totalAmount = 0;
                double discount = 0;

                // Check number of courses
                if (courseCount >= 1 && courseCount <= 8)
                {
                    // Calculate tuition fee
                    if (studyYear == 1)
                    {
                        tuitionFee = courseCount * 40;
                    }
                    else if (studyYear == 2)
                    {
                        tuitionFee = courseCount * 45;
                    }
                    else if (studyYear == 3)
                    {
                        tuitionFee = courseCount * 50;
                    }
                    else if (studyYear == 4)
                    {
                        tuitionFee = courseCount * 55;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a study year from 1 to 4.");
                    }

                    // Give discount to students taking 6 or more courses
                    if (courseCount >= 6)
                    {
                        discount = tuitionFee * 0.10;
                    }

                    
                    totalAmount = tuitionFee + transportFee - discount;

                  
                    tblnameoutput.Text = "Student Name: " + studentName;
                    tblidoutput.Text = "Student ID: " + studentID;
                    tblcoursesoutput.Text = "Total Courses: " + courseCount;
                    lblstudyoutput.Text = "Study Year: " + studyYear;
                    lbltransportoutput.Text = "Transportation Fee: " + transportFee;
                    lbldiscountoutput.Text = "Discount Amount: " + discount;
                    lbltutionoutput.Text = "Tuition Fee: " + tuitionFee;
                    lblfinaloutput.Text = "Total Amount to Pay: " + totalAmount;
                }
                else
                {
                    MessageBox.Show("Please enter a number of courses between 1 and 8.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please check your information and try again.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtcourses.Clear();
            txtlevel.Clear();
            txttransport.Clear();


            tblnameoutput.Text = "Name :";
            tblidoutput.Text = "Id :";
            tblcoursesoutput.Text = "Number Courses :";
            lblstudyoutput.Text = "Study year :";
            lbltransportoutput.Text = "Transport Fee :";
            lbldiscountoutput.Text = "Discount :";
            lbltutionoutput.Text = "Tuition fee :";
            lblfinaloutput.Text = "Final Amount :";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
