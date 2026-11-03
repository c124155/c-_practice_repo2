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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace assigment_arbacada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            output = File.CreateText("C:\\Users\\IQRA\\Documents\\iqra\\zaada.txt");


            output.WriteLine("c# programing");
            output.WriteLine("welcome");
            output.WriteLine("ca242");

            output.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter write;
            DialogResult result;
            result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                write = new StreamWriter(saveFileDialog1.FileName);
                write.WriteLine(textBox1.Text);
                write.Close();
                MessageBox.Show("save filed");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader read;
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                read = new StreamReader(openFileDialog1.FileName);
                string lines;
                while (read.EndOfStream == false)
                {
                    lines = read.ReadLine();
                    listBox1.Items.Add(lines);
                }
            }
        }
    }
}
