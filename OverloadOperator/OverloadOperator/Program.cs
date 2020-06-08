using System;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating both objects in the Employee class
            //and setting values to properties
            Employee employee1 = new Employee();
            employee1.Id = 50;
            Employee employee2 = new Employee();
            employee2.Id = 50;

            //Checking equality of the objects
            Console.WriteLine(employee1 != employee2);

        }
    }
}

