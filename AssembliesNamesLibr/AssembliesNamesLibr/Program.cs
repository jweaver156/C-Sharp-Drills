using System;

namespace AssembliesNamesLibr
{
    class Program
    {
        static void Main(string[] args)
        {
            const string doesNotChange = "I am a constant variable";
            Console.WriteLine("{0} and will never change.", doesNotChange);

            var num = 7;
            Console.WriteLine(num);

            ChainConstr chainConstr = new ChainConstr();
            Console.WriteLine(chainConstr.favBev);
        }
    }
}
