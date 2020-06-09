using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListString = { "Using", "generics", "have", "it\'s", "advantages." };

            Employee<string> EmployStr  = new Employee<string>(ListString);
            EmployStr.print();

            int[] ListInt = { 10, 20, 30, 40, 50 };

            Employee<int> EmployInt = new Employee<int>(ListInt);
            EmployInt.print();
        }
    }
}
