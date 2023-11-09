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

        protected void btnOne_Click(object sender, EventArgs e)
        {
            if((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "x")||(TextBox1.Text == "÷"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
        }
    }
}