using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonversiMataUang
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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label4.Text = "$" + Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000070);
            }
            else if (radioButton2.Checked)
            {
                label4.Text = "¥" + Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0076);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
