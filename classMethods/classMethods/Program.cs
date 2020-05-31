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
            int value = 0;
            Console.Write("Enter a value: ");
            int.TryParse(Console.ReadLine(),out value);

            //Instance of Tester Class
            Tester tester = new Tester();

            //Call First Method
            Console.WriteLine("The double value of {0} is {1}", value, tester.multiplyBy2(value));

            //Call Second Method
            Console.WriteLine("The square value of {0} is {1}", value, tester.getSquare(value));

            //Call Third Method
            Console.WriteLine("The square root value of {0} is {1}", value, tester.getSquareRoot(value));

            Console.ReadLine();
        }
    }
}
