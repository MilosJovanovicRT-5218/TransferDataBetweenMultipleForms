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
    public partial class Form2 : Form
    {
        public static Form2 formTwoInstance;
        public Label lab1;
        public Label lab2;
        public Label lab3;

        public Form2()
        {
            InitializeComponent();
            formTwoInstance = this;
            lab1 = label1;
            lab2 = label2;
            lab3 = label3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Name : " + Form1.formOneInstance.tb1.Text;
            label2.Text = "Surname : " + Form1.formOneInstance.tb2.Text;
            label3.Text = "City : " + Form1.formOneInstance.tb3.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Name : " ;
            label2.Text = "Surname : " ;
            label3.Text = "City : " ;

            Form1.formOneInstance.tb1.Text = "";
            Form1.formOneInstance.tb2.Text = "";
            Form1.formOneInstance.tb3.Text = "";
        }
    }
}
