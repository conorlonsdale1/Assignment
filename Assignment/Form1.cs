using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Resistor1, Resistor2, ResistanceT;
                Resistor1 = Convert.ToDouble(textBox1.Text);
                Resistor2 = Convert.ToDouble(textBox2.Text);
                ResistanceT = Resistor1 + Resistor2;
                label3.Text = "Restistance = " + ResistanceT;
            }
            catch
            {
                MessageBox.Show("Type in two numbers.");
            }
        }
    }
}
