using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto1_Calculadora
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //botones numeros
        protected void btnTwo_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
        }

        //botones del 0 al 9
        protected void btnThree_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
        }

        protected void btnOne_Click1(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x") || (TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
        }

        //botones de operaciones
        protected void btnAddition_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            Global.num2 = '+';
            TextBox1.Text += Global.num2;
        }

        protected void btnSubtraction_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            Global.num2 = '-';
            TextBox1.Text += Global.num2;
        }

        protected void btnMultiplication_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            Global.num2 = 'x';
            TextBox1.Text += Global.num2;
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            Global.num2 = '÷';
            TextBox1.Text += Global.num2;
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            Global.num3 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if (Global.num2 == '÷')
            {
                Global.num4 = Global.num1 / Global.num3;
                TextBox1.Text += Global.num4;
                Global.num1 = Global.num4;
            }
            else if (Global.num2 == '+')
            {
                Global.num4 = Global.num1 + Global.num3;
                TextBox1.Text += Global.num4;
                Global.num1 = Global.num4;
            }
            else if (Global.num2 == '-')
            {
                Global.num4 = Global.num1 - Global.num3;
                TextBox1.Text += Global.num4;
                Global.num1 = Global.num4;
            }
            else if (Global.num2 == 'x')
            {
                Global.num4 = Global.num1 * Global.num3;
                TextBox1.Text += Global.num4;
                Global.num1 = Global.num4;
            }

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        //botones demas operaciones
        //andrey
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {

                if (Global.num1 == 0)
                {
                    Global.num1 = (float)Convert.ToDouble(TextBox1.Text);
                    TextBox1.Text = "";
                }
                else
                {

                    Global.num3 = (float)Convert.ToDouble(TextBox1.Text);


                    double result = Math.Pow(Global.num1, Global.num3);
                    TextBox1.Text = result.ToString();


                    Global.num1 = 0;
                    Global.num2 = ' ';
                    Global.num3 = 0;
                    Global.num4 = 0;
                }
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double num = Convert.ToDouble(TextBox1.Text);
                double result = Math.Pow(10, num);
                TextBox1.Text = result.ToString();
            }
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double num = Convert.ToDouble(TextBox1.Text);
                double result = Math.Log10(num);
                TextBox1.Text = result.ToString();
            }
        }

        protected void btnPow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double num = Convert.ToDouble(TextBox1.Text);
                double result = Math.Pow(num, 2);
                TextBox1.Text = result.ToString();
            }
        }

        //karla
        protected void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double currentNumber = Convert.ToDouble(TextBox1.Text);
                currentNumber = -currentNumber;
                TextBox1.Text = currentNumber.ToString();
            }
        }

        protected void btnComaDecimal_Click(object sender, EventArgs e)
        {
            if (!TextBox1.Text.Contains(","))
            {
                TextBox1.Text += ",";

            }
        }
    }

}