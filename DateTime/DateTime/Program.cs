using System;


namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a single digit number");
            int hours = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(DateTime.Now.AddHours(hours));

        }
    }
}
