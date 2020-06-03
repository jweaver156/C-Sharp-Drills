using System;
using System.Runtime.InteropServices;
namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //Instantiate object from Math class
            Math math = new Math();

            //Calling method
            int result = math.MathOp(12);
            Console.WriteLine(result);

            //Asking for input from user
            Console.Write("Input a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            //Taking input identifing if input was given then converting to int
            //Calling function if optional input was given by user
            //Otherwise printing initial value
            Console.Write("Input an additional number if you would like or press enter: ");
            string input = Console.ReadLine();

            if (input.Length > 0)
            {
                int num2 = Convert.ToInt32(input);
                sum = math.MathOp(num1, num2);
            }
            else
            {
                sum = math.MathOp(num1);
            }
            Console.WriteLine("sum = {0}", sum);
        }

    }
}
