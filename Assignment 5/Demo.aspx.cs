using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void factorial_Click(object sender, EventArgs e)      // Button click event definition for factorial button.
        {
            Models.Operations oprFact = new Models.Operations();        //initialize new object of Models.Operations class
            oprFact.getUsetInput(Convert.ToInt32(inputTxt.Text));       //Assign user input
            result.Text = oprFact.Factorial().ToString();               //assigning result value to the result label.
        }

        protected void sum_Click(object sender, EventArgs e)            //Button click event for sum button.
        {
            Models.Operations oprFact = new Models.Operations();        //initialize new object of Models.Operations class
            oprFact.getUsetInput(Convert.ToInt32(inputTxt.Text));       //Assign user input
            result.Text = oprFact.Sum().ToString();                     //assigning result value to the result label.
        }
    }
}