using System;
namespace Generic
{
    public class Employee<T>
    {
        public T[] things;

        public Employee(T[] items)
        {
            things = items;
        }

        public void print()
        {
            for (int i = 0; i < things.Length; i++)
            {
                Console.Write(things[i] + " ");                
            }               
        }
    }
}
