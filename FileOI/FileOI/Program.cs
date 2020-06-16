using System;
using System.IO;

namespace FileOI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string userNum = Console.ReadLine();

            File.WriteAllText(@"Users\John\Documents\log\log.txt", userNum);

            Console.WriteLine(File.ReadAllText(@"Users\John\Documents\log\log.txt"));
            Console.ReadLine();
        }
    }
}
