using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string function = ""; 
        double value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")  // if value = 0,clear and add one 
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";    //clear all value
            label1.Text = "";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            string a = txtOutput.Text;     
            string b = txtOutput.Text.Substring(0, a.Length - 1);    // substring last words count from 0
            if (b.Length == 0)
            {
                b = "0";
            }
            txtOutput.Text = b;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Clear();
            }
            txtOutput.Text += ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtOutput.Text);      // 0 = getValue from txt
            function = "divided";
           /* txtOutput.Clear(); */                        // saved in value and clear it  
            label1.Visible = true;                      
            label1.Text = value.ToString() + " /";      // display the value and operation
            label1.BackColor = DefaultBackColor;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtOutput.Text);
            function = "multiply";
            //txtOutput.Clear();
            label1.Visible = true;
            label1.Text = value.ToString() + " *";
            label1.BackColor = DefaultBackColor;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtOutput.Text);
            function = "minus";
            //txtOutput.Clear();
            label1.Visible = true;
            label1.Text = value.ToString() + " -";
            label1.BackColor = DefaultBackColor;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtOutput.Text);
            function = "plus";
            //txtOutput.Clear();
            label1.Visible = true;
            label1.Text = value.ToString() + " +";
            label1.BackColor = DefaultBackColor;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")                         
            {
                label1.Text = "Please insert value!!";      
                label1.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                switch (function)
                {
                    case "divided":
                        value /= double.Parse(txtOutput.Text);      
                        txtOutput.Text = value.ToString();
                        break;

                    case "multiply":
                        value *= double.Parse(txtOutput.Text);
                        txtOutput.Text = value.ToString();
                        break;

                    case "minus":
                        value -= double.Parse(txtOutput.Text);
                        txtOutput.Text = value.ToString();
                        break;

                    case "plus":
                        value += double.Parse(txtOutput.Text);
                        txtOutput.Text = value.ToString();
                        break;
                }
                function = "";
                label1.Text = "";
            }
        }
    }
}
