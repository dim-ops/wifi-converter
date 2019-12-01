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
        // result label1
        double result;

        //Dictionnary Power Cisco
        Dictionary<string, int> Cisco = new Dictionary<string, int>();

        //Value Cisco Dictionnary
        //Test 1
            {
                { "Tx" , 23},
                {"Tx 2", 20}
            }
        //Test 2
         
            Cisco["Neel Beniwal"] = 9;

        //Test 3
            Cisco.Add("Tx Power Level 1", 23); 
            Cisco.Add("Tx Power Level 2", 20); 
            Cisco.Add("Tx Power Level 3", 17); 
            Cisco.Add("Tx Power Level 4", 14); 
            Cisco.Add("Tx Power Level 5", 11); 
            Cisco.Add("Tx Power Level 6", 8);


        private ActionResult View(object model)
        {
            throw new NotImplementedException();
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

            //Cisco label
            //Label2.Text = "Cisco value : " + "dB" ;

            

        }

        
    }

    internal class ExampleViewModel
    {
        public ExampleViewModel()
        {
        }
    }

    public class ActionResult
    {
    }
}