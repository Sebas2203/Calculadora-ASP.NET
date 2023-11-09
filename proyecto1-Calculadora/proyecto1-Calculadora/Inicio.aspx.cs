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
        Global global = new Global();
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

        }

        protected void btnSubtraction_Click(object sender, EventArgs e)
        {
            global.num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            global.num2 = '-';
            TextBox1.Text += global.num2;
        }

        protected void btnMultiplication_Click(object sender, EventArgs e)
        {

        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            global.num3 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if (global.num2 == '÷')
            {
                global.num4 = global.num1 / global.num3;
                TextBox1.Text += global.num4;
                global.num1 = global.num4;
            }
            else if (global.num2 == '+')
            {
                global.num4 = global.num1 + global.num3;
                TextBox1.Text += global.num4;
                global.num1 = global.num4;
            }
            else if (global.num2 == '-')
            {
                global.num4 = global.num1 - global.num3;
                TextBox1.Text += global.num4;
                global.num1 = global.num4;
            }
            else
            {
                global.num4 = global.num1 * global.num3;
                TextBox1.Text += global.num4;
                global.num1 = global.num4;
            }
        }
    }
}