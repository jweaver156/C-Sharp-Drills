using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
    
            Console.Write("Enter a number you would like to multiply by 2,\nget the square value of,\nand find the square root of: ");
            int.TryParse(Console.ReadLine(),out value);

            //Instance of Tester Class
            Tester tester = new Tester();

            //Call First Method
            Console.WriteLine("{0} multiplied by 2 is {1},", value, tester.multiplyBy2(value));

            //Call Second Method
            Console.WriteLine("{0} squared is {1},", value, tester.getSquare(value));

            //Call Third Method
            Console.WriteLine("and the square root of {0} is {1}.", value, tester.getSquareRoot(value));

            Console.ReadLine();
        }
    }
}
