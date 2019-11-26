using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConverterDocker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
 
        //int i;
        double result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox_1(object sender, EventArgs e)
        {
            //prendre la valeur RequiredPower
            string RequiredPower = TextBox1.Text;
            //Value1 = 0;

        }

        protected void TextBox_2(object sender, EventArgs e)
        {
            //prendre la valeur AntennaGain
            string AntennaGain = TextBox2.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //formule a indiquer
            //i = test + test2;
            result = 10*Math.Log10(Int32.Parse(TextBox1.Text)/1)- Int32.Parse(TextBox2.Text);
            //Label1.Text = i.ToString();
            Label1.Text = "Result : " + result.ToString() + " dB";

            

        }

        
    }
}