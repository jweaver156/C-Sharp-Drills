using System;

namespace MultiMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            ClassOne classOne = new ClassOne();

            Console.Write("Enter a value: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            classOne.DivideBy(num1);

            int a = 10;
            classOne.NumChanger(out a);

            Console.WriteLine("The value after the NumChanger method call is {0}", a);

            classOne.OverloadMthd(x: 2, y: 3);


            StaticOne.name = "John";
            StaticOne.location = "Portland";

            Console.WriteLine("My name is {0}", StaticOne.name);
            Console.WriteLine("My location is {0}", StaticOne.location);












        }
    }
}
