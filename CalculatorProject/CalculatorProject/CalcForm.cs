using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        double fNum;  //first number input
        string operation;

        private void logo_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "0";
        }

        private void buttonDec_Click(object sender, EventArgs e) //decimal (period)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void buttonEq_Click(object sender, EventArgs e) //equals/finishes operation
        {
            if(textBox1.Text.Length > 0)
            { 
                double secNum;
                double ans;

                secNum = Convert.ToDouble(textBox1.Text);

                if (operation == "+") // if add button hit
                 {
                    ans = (fNum + secNum);
                    textBox1.Text = Convert.ToString(ans);
                    fNum = ans;
                 }
    
                 if (operation == "-")
                 {
                     ans = (fNum - secNum);
                     textBox1.Text = Convert.ToString(ans);
                     fNum = ans;
                }

                if (operation == "*")
                {
                    ans = (fNum * secNum);
                    textBox1.Text = Convert.ToString(ans);
                    fNum = ans;
                }

                if (operation == "/")
                {
                    if (secNum == 0)
                    {
                        textBox1.Text = "Cannot divide by 0";
                    }
                    else
                    {
                        ans = (fNum / secNum);
                        textBox1.Text = Convert.ToString(ans);
                        fNum = ans;
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) //if textbox is populated, remove character 
            {                             //prevents error out when no character in textbox
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); //deletes last number inputted to text box
            }
        }

        private void buttonClr_Click(object sender, EventArgs e) 
        {
            textBox1.Clear(); //clear text box
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = "/";
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = "*";
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = "-";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = "+";
            }

        }
    }
}
