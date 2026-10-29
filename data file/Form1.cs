using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter newfile;
            // creating new file create texe()
            newfile = File.CreateText("c##");

            //process file
            newfile.WriteLine("welcome");
            newfile.WriteLine("age:22");
            newfile.WriteLine(" c# programing ");
            // the close file
            newfile.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] z = File.ReadAllBytes("c##");
            MessageBox.Show("tirada byte-yada" + z.Length);
            foreach (byte b in z)
            {
                listBox1.Items.Add(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string del = ("c##");
            if (File.Exists(del))
            {
                File.Delete(del);
                MessageBox.Show("fil ka waldaleday");
            }
            else
            {
                MessageBox.Show("file ka lama dirin");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "c##";
             

                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    StreamWriter writer = File.CreateText(filePath);
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    writer.Close();

                    MessageBox.Show("faldan itemkarabtay wala dooraty");
                }
                else
                {
                    MessageBox.Show("Fadlan marka hore ListBox-ka ka dooro item-ka aad rabto inaad tirtirto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
