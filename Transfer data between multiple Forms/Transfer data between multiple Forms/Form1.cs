using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transfer_data_between_multiple_Forms
{
    public partial class Form1 : Form
    {
        public static Form1 formOneInstance;
        public TextBox tb1;
        public TextBox tb2;
        public TextBox tb3;
        public Form1()
        {
            InitializeComponent();
            formOneInstance = this;
            tb1 = textBox1;
            tb2 = textBox2;
            tb3 = textBox3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.BackColor = TransparencyKey;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2.formTwoInstance.lab1.Text = "Name : " + tb1.Text;
            Form2.formTwoInstance.lab2.Text = "Surname : " + tb2.Text;
            Form2.formTwoInstance.lab3.Text = "City : " + tb3.Text;
        }
    }
}
