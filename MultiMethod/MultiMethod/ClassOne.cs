using System;
namespace MultiMethod
{
    public class ClassOne
    {
        public void DivideBy(int num1)
        {
            num1 /= 2;

            Console.WriteLine("Your number divided by two is {0}", num1);
            Console.ReadLine();


        }

        public void NumChanger(out int result)
        {
            result = 10;
        }

        public void OverloadMthd(int x)
        {
            x = 15;
        }
        
        public void OverloadMthd(int x, int y)
        {
            x = 10;
            y = 20;
        }
        
    }
}
