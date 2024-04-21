using System;

namespace Calculator
{
    /// <summary>
    /// Class runs calculations
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method containing string
        /// </summary>
        static void Main()
        {
            double num1;
            double num2;

            //Stores answer
            string answer;

            //Integer holds result of calculation
            double result;
            
            Console.WriteLine("Hello, welcome to the Calculator program.");
            Console.WriteLine("Please, enter your first number.");

            //Convert string data into an integer: "Casting"..ReadLine returns a string but we needed to return an integer.
            num1 = Convert.ToDouble(Console.ReadLine());

            //Asking user for another number
            Console.WriteLine("Please, enter your second number.");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine( "What type of operation would you like to do? ");
            Console.WriteLine("Please, enter: a for addition, s for subtraction, m for multiplication or any other key for division.");

            answer = Console.ReadLine();

            //Make decision based on answer entered. 
            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s") {
                result = num1 - num2;
            }
            else if (answer == "m") {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the Calculator program!");
            Console.ReadKey();
        }
    }
}
