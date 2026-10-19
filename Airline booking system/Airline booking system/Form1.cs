using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            string passengerName;
            int passengerAge;
            int ticketCount;
            double baggageWeight;

            // Ticket calculations
            int insuranceRate = 25;
            double ticketPrice = 0;
            double basicCost = 0;
            double ticketDiscount = 0;
            double passengerDiscount = 0;
            double insuranceCost = 0;
            double baggageCharge = 0;
            double amountToPay = 0;

            // Booking decision
            string bookingResult = "";

            // Price for one ticket
            double ticketRate = 75;

            if (int.TryParse(txtage.Text, out passengerAge) &&
                int.TryParse(txttickets.Text, out ticketCount) &&
                double.TryParse(txtbaggage.Text, out baggageWeight))
            {
                
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for age, tickets, and baggage weight.");
            }

            // Get passenger information
            passengerName = txtname.Text;
            passengerAge = int.Parse(txtage.Text);
            ticketCount = int.Parse(txttickets.Text);
            baggageWeight = double.Parse(txtbaggage.Text);


            // Check passenger age
            if (passengerAge >= 1 && passengerAge <= 100)
            {

            }
            else
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
            }

            // Select travel class
            if (rdfirst.Checked)
            {
                ticketRate = 150;
            }
            else if (rdnormal.Checked)
            {
                ticketRate = 300;
            }
            else if (rdbussiness.Checked)
            {
                ticketRate = 500;
            }

            // Check booking eligibility
            if (passengerAge < 12 && rdfirst.Checked)
            {
                bookingResult = "Rejected";
            }
            else
            {
                bookingResult = "Approved";
            }

            // Calculate ticket price
            ticketPrice = ticketCount * ticketRate;

            // Calculate insurance cost
            if (cbinsurance.Checked)
            {
                insuranceCost = ticketCount * insuranceRate;
            }
            else
            {
                insuranceCost = 0;
            }

            // Calculate baggage charge
            baggageCharge = baggageWeight * 1;

            // Check ticket quantity
            if (ticketCount >= 1 && ticketCount <= 5)
            {
                
            }
            else
            {
                MessageBox.Show("You can book between 1 and 5 tickets.");
            }

            // Check baggage weight
            if (baggageWeight >= 1 && baggageWeight <= 50)
            {
                
                
            }
            else
            {
                MessageBox.Show("Baggage weight must be between 1 and 50 kg.");
            }

            // Calculate discount based on ticket quantity
            if (ticketCount >= 3 && ticketCount <= 4)
            {
                ticketDiscount = ticketPrice * 0.05;

                // Calculate passenger age discount
                if (passengerAge <= 12 && rdnormal.Checked)
                {
                    passengerDiscount = ticketDiscount * 0.20;
                }
                else if (passengerAge <= 12 && rdbussiness.Checked)
                {
                    passengerDiscount = ticketDiscount * 0.20;
                }
                else if (passengerAge >= 60)
                {
                    passengerDiscount = ticketDiscount * 0.10;
                }
                else
                {
                    passengerDiscount = 0;
                }
            }
            else if (ticketCount >= 5)
            {
                ticketDiscount += ticketPrice * 0.10;

                // Calculate passenger age discount
                if (passengerAge <= 12 && rdnormal.Checked)
                {
                    ticketDiscount += ticketPrice * 0.20;
                }
                else if (passengerAge <= 12 && rdbussiness.Checked)
                {
                    ticketDiscount += ticketPrice * 0.20;
                }
                else if (passengerAge >= 60)
                {
                    ticketDiscount += ticketPrice * 0.10;
                }
                else
                {
                    ticketDiscount += 0;
                }
            }
            else
            {
                ticketDiscount = 0;
            }

            // Display booking information
            if (passengerAge < 12 && rdfirst.Checked)
            {
                listBox1.Items.Add("airline info");

                listBox1.Items.Add("Passenger Name: " + passengerName);
                listBox1.Items.Add("Passenger Age: " + passengerAge);
                listBox1.Items.Add("Number of Tickets: " + ticketCount);
                listBox1.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                listBox1.Items.Add("Booking Result: " + bookingResult);

                MessageBox.Show("Passengers under 12 years old cannot book First Class.");
            }
            else
            {
                // Calculate final amount
                amountToPay = (ticketPrice + insuranceCost + baggageCharge)
                              - ticketDiscount - passengerDiscount;

                // Display booking information
                listBox1.Items.Add("airline info");
                listBox1.Items.Add("Passenger Name: " + passengerName);
                listBox1.Items.Add("Passenger Age: " + passengerAge);
                listBox1.Items.Add("Number of Tickets: " + ticketCount);
                listBox1.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                listBox1.Items.Add("");
                listBox1.Items.Add("Ticket Price: " + ticketPrice);
                listBox1.Items.Add("Ticket Discount: " + ticketDiscount);
                listBox1.Items.Add("Passenger Discount: " + passengerDiscount);
                listBox1.Items.Add("Insurance Cost: " + insuranceCost);
                listBox1.Items.Add("Baggage Charge: " + baggageCharge);
                listBox1.Items.Add("");
                listBox1.Items.Add("Total Amount to Pay: " + amountToPay);
                listBox1.Items.Add("");
                listBox1.Items.Add("Booking Result: " + bookingResult);
            }

        }
    }
}
