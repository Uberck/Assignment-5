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
        protected void factorial_Click(object sender, EventArgs e)                 // Button click event definition for factorial button
        {
            Models.Operations factorialOperation = new Models.Operations();        // Initializes a new object of the Models.Operations class
            factorialOperation.getUserInput(Convert.ToInt32(inputTxt.Text));       // Assigns user input from the inputTxt text field
            result.Text = factorialOperation.Factorial().ToString();               // Assigns result value to the result label, prints the result as a string value
        }

        protected void sum_Click(object sender, EventArgs e)                        // Button click event for sum button
        {
            Models.Operations sumOperation = new Models.Operations();               // Initializes a new object of the Models.Operations class
            sumOperation.getUserInput(Convert.ToInt32(inputTxt.Text));              // Assigns user input from the inputTxt text field
            result.Text = sumOperation.Sum().ToString();                            // Assigns the result value to the result label, prints the result as a string value
        }
    }
}