using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods
{
    public class Tester
    {
        public int value;
        public Tester(int value)
        {
            this.value = value;
        }

        //First Method Multiply Value By 2
        public int multiplyBy2()
        {
            int doubleValue = 2 * value;
            return doubleValue;
        }

        //Second Method Returns the Square Root of Value
        public int getSquare()
        {
            int square = value * value;
            return square;
        }

        //Third Method Returns Square Root of Value
        public double getSquareRoot()
        {
            double root = Math.Sqrt(value);
            return root;
        }
    }
}
