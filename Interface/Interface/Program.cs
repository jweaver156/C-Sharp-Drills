using System;
using Interface;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}    