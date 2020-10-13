using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_5.Models
{
    public class Operations
    {
        private int userInput;
        public void getUserInput(int UserInput)         // Assign user input to public get method
        {
            userInput = UserInput;
        }
        public int Factorial()                         // Method to calculate factorial with no parameters, returns int
        {
            int result = userInput;
            for (int i = 1; i < userInput; i++)         // Loop to calculate the factorial (int * int * int...)
            {
                result = result * i;                    // Iterate up to the value of userInput one integer at a time
            }
            return result;
        }
        public int Sum()                                // Method to calculate sum with no parameters, returns int
        {
            int result = 0;                             
            for (int i = 1; i <= userInput; i++)        // For loop to calculate the Sum (int + int + int...)
            {
                result = result + i;                    // Iterate up to the value of userInput one integer at a time
            }
            return result;
        }

    }
}