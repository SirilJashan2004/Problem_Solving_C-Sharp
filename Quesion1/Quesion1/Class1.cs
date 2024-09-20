using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesion1
{
    public class Class1
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Product(int a, int b)
        {
            return a * b;
        }
        public int Difference(int a, int b)
        {
            return Math.Abs(a - b);
        }

        public float Quotient(int a, int b)
        {
            return (float)a/b ;
        }
        public int Remainder(int a, int b)
        {
            return a % b;
        }
    }
}
