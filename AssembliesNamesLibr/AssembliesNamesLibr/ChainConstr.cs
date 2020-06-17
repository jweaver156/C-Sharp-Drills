using System;
namespace AssembliesNamesLibr
{
    public class ChainConstr
    {
        public string favBev;
        public ChainConstr() : this("Coffee")
        {
            
        }

        public ChainConstr(string bestBev)
        {
            favBev = bestBev;
        }
    }
}
