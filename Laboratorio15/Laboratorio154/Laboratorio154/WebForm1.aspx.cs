using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num1 = this.TextBox1.Text;
            string num2 = this.TextBox2.Text;

            int x = 0;
            int y = 0;
            try
            {
                x = int.Parse(num1);
                y = int.Parse(num2);
            }
            catch (Exception ex)
            {
                return;
            }


            this.Label2.Text = $"{x + y}";
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}