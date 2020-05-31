using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodsParameters
{
    public class Tester
    {
        private int value;
        public Tester()
        {
            this.value = value;
        }

        //First Method Multiply Value By 2
        public int multiplyBy2(int value)
        {
            int doubleValue = 2 * value;
            return doubleValue;
        }

        //Second Method Returns the Square Root of Value
        public int getSquare(int value)
        {
            int square = value * value;
            return square;
        }

        //Third Method Returns Square Root of Value
        public double getSquareRoot(int value)
        {
            double root = Math.Sqrt(value);
            return root;
        }
    }
}
