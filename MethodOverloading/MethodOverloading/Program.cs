using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatnsting object for class Solutions
            Solutions solutions = new Solutions();

            //Call function for int.
            int res = solutions.Eval(4);
            Console.WriteLine(res);

            //Call function for double into int.
            res = solutions.Eval(7.25);
            Console.WriteLine(res);

            //Call function for string into int.
            res = solutions.Eval("20");
            Console.WriteLine(res);
        }
    }
}
