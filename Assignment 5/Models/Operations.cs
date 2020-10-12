using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_5.Models
{
    public class Operations
    {
        private int userInput;
        public void getUsetInput(int UserInput)         // Public Method to assign user input
        {
            userInput = UserInput;
        }
        public long Factorial()                         // Method to calculate factorial. Taking long instead of int to calculate factorial of large values
        {
            long result = userInput;
            for (int i = 1; i < userInput; i++)         // Loop to calculate factorial.
            {
                result = result * i;                    // Updating result value every time. e.g. 5! = 5 * 4 * 3 * 2 * 1
            }
            return result;
        }
        public int Sum()                                // Method to calculate Sum
        {
            int result = 0;
            for (int i = 1; i <= userInput; i++)        // Loop to calculate Sum.
            {
                result = result + i;                    // Updating result value every time. e.g. 5! = 5 * 4 * 3 * 2 * 1
            }
            return result;
        }

    }
}