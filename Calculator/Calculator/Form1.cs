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
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string value1 = string.Empty;
        string value2 = string.Empty;        
        string operation;
        string temp = string.Empty;
        double answer = 0.0;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 7;
            this.Display.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 8;
            this.Display.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 9;
            this.Display.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 4;
            this.Display.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 5;
            this.Display.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 6;
            this.Display.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 1;
            this.Display.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 2;
            this.Display.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 3;
            this.Display.Text += input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += 0;
            this.Display.Text += input;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculation();       
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
           value1 = input;
            operation = "/";
           input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = "*";
            input = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = "-";
            input = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = "+";
            input = string.Empty;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            input += '-';
            this.Display.Text += input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            this.input = string.Empty;
            this.value1 = string.Empty;
            this.value2 = string.Empty;
            lblError.Visible = false;
            temp = string.Empty;
            lblError.Visible = false;
            btnPlus.Enabled = true;
            btn9.Enabled = true;
            btn8.Enabled = true;
            btn7.Enabled = true;
            btn6.Enabled = true;
            btn5.Enabled = true;
            btn4.Enabled = true;
            btn3.Enabled = true;
            btn2.Enabled = true;
            btn1.Enabled = true;
            btnNegative.Enabled = true;
            btnDecimal.Enabled = true;
            btnDivide.Enabled = true;
            btnEqual.Enabled = true;
            btn0.Enabled = true;
            btnMinus.Enabled = true;
            btnDelete.Enabled = true;
            btnMultiply.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Display.Text != answer.ToString() && Display.Text != string.Empty) //checking to see if there is using input to delete
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                input = Display.Text;
            }

        }

        private void Calculation()
        {
            value2 = input;
            double set1, set2;

            if (temp != string.Empty) //checking if there is a previous answer user is using math on, if yes it will build on the previous answer
            {
                value1 = temp;
            }
            
            double.TryParse(value1, out set1);
            double.TryParse(value2, out set2);


            if (operation == "/")
            {
                if (set2 > 0)
                {
                    answer = set1 / set2;
                    Display.Text = answer.ToString();
                }
                else
                    Error();
            }
            else if (operation == "*")
            {
                answer = set1 * set2;
                Display.Text = answer.ToString();
            }
            else if (operation == "-")
            {
                answer = set1 - set2;
                Display.Text = answer.ToString();
            }
            else if (operation == "+")
            {
                answer = set1 + set2;
                Display.Text = answer.ToString();
            }

            temp = answer.ToString(); //storing answer 
        }

        private void Error()
        {
            lblError.Visible = true;
            btnPlus.Enabled = false;
            btn9.Enabled = false;
            btn8.Enabled = false;
            btn7.Enabled = false;
            btn6.Enabled = false;
            btn5.Enabled = false;
            btn4.Enabled = false;
            btn3.Enabled = false;
            btn2.Enabled = false;
            btn1.Enabled = false;
            btnNegative.Enabled = false;
            btnDecimal.Enabled = false;
            btnDivide.Enabled = false;
            btnEqual.Enabled = false;
            btn0.Enabled = false;
            btnMinus.Enabled = false;
            btnDelete.Enabled = false;
            btnMultiply.Enabled = false;
        }

    }
}
