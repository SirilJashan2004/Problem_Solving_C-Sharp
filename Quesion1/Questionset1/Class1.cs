using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionset1
{
    public class Class1
    {

        public long Sum(int a, int b)
        {
            return (long)a + b;
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
            return (float)a / b;
        }
        public int Remainder(int a, int b)
        {
            return a % b;
        }
        public float Simple(float p, float n, float r)
        {
            return (p * n * r / 100);
        }
        public int GetLarge(int a, int b, int c)
        {
            int large=0;
            if (a < b)
            {
                large = b;
            }
            else
            {
                large = a;
            }
            if (large<c)
            {
                large = c;
            }
            return large;
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public bool IsVowel(char Letter)
        {
            return (Letter == 'a' || Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u') ? true : false;
        }
        
    }
}
