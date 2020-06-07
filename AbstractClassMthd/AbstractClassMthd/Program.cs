using System;

namespace AbstractClassMthd
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
        }
    }
}
