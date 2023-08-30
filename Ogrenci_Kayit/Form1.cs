using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Kayit
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox5.Text = textBox1.Text;
            textBox4.Text = textBox2.Text;
            textBox6.Text = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) groupBox1.Visible = true;
            else groupBox1.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }
    }
}
