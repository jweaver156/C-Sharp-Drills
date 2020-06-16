using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employList = new List<string>()
            {
                "Joe Duffy, ID: 1",
                "Joe Smith, ID: 2",
                "Hamilton Koepeck, ID: 3",
                "Samantha Burns, ID: 4",
                "Kim Cho, ID: 5",
                "Dave Tuttle, ID: 6",
                "Shasha Timmons, ID: 7",
                "Garlin Pence, ID: 8",
                "Erica Tabor, ID: 9",
                "Tim Sears, ID: 10"
            };

            List<String> JoeList = new List<string>();

            Console.WriteLine("Here is the list of all people whose first name is Joe");
            foreach (var name in employList)
            {
                if (name.Contains("Joe"))
                {
                    JoeList.Add(name);          
                }
            }

            employList.ForEach(employees =>
            {
                if (employees.Contains("Joe"))
                {
                    JoeList.Add(employees);
                    Console.WriteLine(employees);
                }
            });

            Console.WriteLine("\nHere is the list of all employees whose id is greater than 5");
            List<String> OverFiveList = new List<string>();
            employList.ForEach(id =>
            {
                string[] splitString = id.Split(new char[] {' '});
                int ID = Int32.Parse(splitString[3]);
                if (ID > 5)
                {
                    OverFiveList.Add(id);
                    Console.WriteLine(id);
                }
            
            });
            
            

        }
    }
}
