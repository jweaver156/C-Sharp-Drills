using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.Write("Enter a value: ");
            int.TryParse(Console.ReadLine(),out value);

            //Instance of Tester Class
            Tester tester = new Tester(value);

            //Call First Method
            Console.WriteLine("The double value of {0} is {1}", value, tester.multiplyBy2());

            //Call Second Method
            Console.WriteLine("The sqaure value of {0} is {1}", value, tester.getSquare());

            //Call Third Method
            Console.WriteLine("The square root value of {0} is {1}", value, tester.getSquareRoot());

            Console.ReadLine();
        }
    }
}
