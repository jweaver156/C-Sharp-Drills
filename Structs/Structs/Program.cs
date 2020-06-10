using System;

namespace Structs
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 1.0m;
            Console.WriteLine(number.Amount);
        }
    }
}
