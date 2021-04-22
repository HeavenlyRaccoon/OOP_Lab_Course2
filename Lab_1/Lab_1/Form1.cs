using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        string operation = "/%*-+";
        bool haveOp = false;
        bool error = false;
        int member = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            haveOp = false;
        }

        private void buttonMOD_Click(object sender, EventArgs e)
        {
            if (!LastOperation())
            {
                if (haveOp)
                {
                    Result();
                    return;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else if (TextBoxCheck(textBox1))
                {
                    textBox1.Text += "%";
                    haveOp = true;
                }
            }
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            if (!LastOperation())
            {
                if (haveOp)
                {
                    Result();
                    return;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else if (TextBoxCheck(textBox1))
                {
                    textBox1.Text += "/";
                    haveOp = true;
                }
            }
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            member = 0;
        }

        private void buttonMRV_Click(object sender, EventArgs e)
        {
            if (LastOperation())
            {
                textBox1.Text += Convert.ToString(member);
            }
            else textBox1.Text = Convert.ToString(member);
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            bool negative = false;
            if (textBox1.Text.First() == '-') negative = true;
            string[] litteral = textBox1.Text.Split('/', '%', '*', '+', '-');
            int num;
            if (negative) { num = Convert.ToInt32(litteral[1]); }
            else num = Convert.ToInt32(litteral[0]);
            if (negative) num *= -1;
            member += num;
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            bool negative = false;
            if (textBox1.Text.First() == '-') negative = true;
            string[] litteral = textBox1.Text.Split('/', '%', '*', '+', '-');
            int num;
            if (negative) { num = Convert.ToInt32(litteral[1]); }
            else num = Convert.ToInt32(litteral[0]);
            if (negative) num *= -1;
            member -= num;
        }
        
        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (!LastOperation())
            {
                if (haveOp)
                {
                    Result();
                    return;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else if (TextBoxCheck(textBox1))
                {
                    textBox1.Text += "*";
                    haveOp = true;
                }
            }
        }
        
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!LastOperation())
            {
                if (haveOp)
                {
                    Result();
                    return;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "-";
                }
                else if (TextBoxCheck(textBox1))
                {
                    textBox1.Text += "-";
                    haveOp = true;
                }
            }
        }
        
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!LastOperation())
            {
                if (haveOp)
                {
                    Result();
                    return;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else if (TextBoxCheck(textBox1))
                {
                    textBox1.Text += "+";
                    haveOp = true;
                }
            }
        }
        
        private void buttonSuprise_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Maroon;
            button.Text = ">:(";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (!LastOperation()) Result();
        }

        private bool TextBoxCheck(TextBox textBox)
        {
            if (textBox.Text.Length == textBox.MaxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool LastOperation()
        {
            if (operation.Contains(textBox1.Text.Last()))
            {
                return true;
            }
            else return false;
        }

        private void Result()
        {
            bool negative = false;
            if (textBox1.Text.First() == '-') negative = true;
            string pattern = "\\b+";
            string[] literal = Regex.Split(textBox1.Text, pattern);
            if (literal.Length == 3) return;
            else
            {
                int num1 = Convert.ToInt32(literal[1]);
                if (negative) num1 *= -1;
                int num2 = Convert.ToInt32(literal[3]);
                switch (literal[2])
                {
                    case "%":
                        {
                            try
                            {
                                textBox1.Text = Convert.ToString(num1 % num2);
                                break;
                            }
                            catch (DivideByZeroException ex)
                            {

                                textBox1.Text = "Divide by Zero";
                                error = true;
                                break;
                            }   
                        }
                    case "/":
                        {
                            try
                            {
                                textBox1.Text = Convert.ToString(num1 / num2);
                                break;
                            }
                            catch (DivideByZeroException ex)
                            {

                                textBox1.Text = "Divide by Zero";
                                error = true;
                                break;
                            }
                            
                        }
                    case "*":
                        {
                            textBox1.Text = Convert.ToString(num1 * num2);
                            break;
                        }
                    case "+":
                        {
                            textBox1.Text = Convert.ToString(num1 + num2);
                            break;
                        }
                    case "-":
                        {
                            textBox1.Text = Convert.ToString(num1 - num2);
                            break;
                        }
                    default:
                        break;
                }
                haveOp = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0"||error)
            {
                textBox1.Text = button.Text;
                error = false;
            }
            else if (TextBoxCheck(textBox1))
            {
                textBox1.Text += button.Text;
            }
        }
    }
    

       
}
