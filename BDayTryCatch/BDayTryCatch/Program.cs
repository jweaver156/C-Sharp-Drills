using System;

namespace BirthYearCalculator
{
    class Program
    {
        // main method
        static void Main(string[] args)
        {
            try
            {
                string ageInput;
                int age;

                // read age as input from user
                Console.WriteLine("Please enter your age:");
                ageInput = Console.ReadLine();

                // check whether the entered age is an integer
                bool isInteger = int.TryParse(ageInput, out age);
                if (isInteger)
                {
                    // check whether age is negative
                    if (age < 0)
                    {
                        Console.WriteLine("Entered age is negative!");
                    }
                    // check whether age is zero
                    else if (age == 0)
                    {
                        Console.WriteLine("Entered age is zero!");
                    }
                    // print birth year as the difference between current year and entered age
                    else
                    {
                        Console.WriteLine("You were born in " + (DateTime.Now.Year - age - 1));
                    }
                }
                // entered age is not an integer
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                // generic exception message
                Console.WriteLine("An error occurred!");
            }
            finally
            {
                // receive a key as input to exit
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

