using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total1;
        string operation = "";
        double total2;
        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnOne.Text;
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btntwo.Text;

        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnthree.Text;
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnfour.Text;
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnfive.Text;
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnsix.Text;
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnseven.Text;
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btneight.Text;
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnnine.Text;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnzero.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (total1 != 0)
            {
                cal();
            }
            else
                total1 =  double.Parse(textBox1.Text);
            textBox1.Clear();
            MessageBox.Show(total1.ToString());
            operation = btnadd.Text;
           
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (total1 != 0)
            {
                cal();
            }
            else
                total1 = double.Parse(textBox1.Text);
           
            textBox1.Clear();
            
            operation = btnsub.Text;

        }

        private void btnMultify_Click(object sender, EventArgs e)
        {
            if (total1 != 0)
            {
                cal();
            }
            else
                total1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = btnMultify.Text;
           
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (total1 != 0)
            {
                cal();
            }
            else
                total1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = btndivide.Text;
           
        }
        private void cal() {
            switch (operation) {

                case "+":
                    total1 = total1 + double.Parse(textBox1.Text);
                    break;
                case "-":
                    total1 = total1 - double.Parse(textBox1.Text);
                    break;
                case "*":
                    total1 = total1 * double.Parse(textBox1.Text);
                    break;
                case "/":
                    total1 = total1 / double.Parse(textBox1.Text);
                    break;
            }
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            cal();

            textBox1.Text = total1.ToString();
            total1 = 0;
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btndo.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            total1 = 0;
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++) {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }
    }
}
