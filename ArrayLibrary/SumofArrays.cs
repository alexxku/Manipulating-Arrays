using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class SumofArrays
    {
        delegate void SumofAllArray();

        int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
        int[] ArrayB = { 1, 3, 5, 7, 9 };
        int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public void SumofArrayA()
        {
            int TotalSum = 0;

            foreach(int x in ArrayA)
            {
                TotalSum += x;
            }

            Console.WriteLine($"Total Sum of ArrayA: {TotalSum}");
        }

        public void SumofArrayB()
        {
            int TotalSum = 0;

            foreach (int x in ArrayB)
            {
                TotalSum += x;
            }

            Console.WriteLine($"Total Sum of ArrayB: {TotalSum}");
        }

        public void SumofArrayC()
        {
            int TotalSum = 0;

            foreach (int x in ArrayC)
            {
                TotalSum += x;
            }

            Console.WriteLine($"Total Sum of ArrayC: {TotalSum}");
        }

        public void SumofAllArraysTogether()
        {
            SumofAllArray SAA;

            Console.WriteLine("\n----Sum of Arrays----");
            SAA = SumofArrayA;
            SAA += SumofArrayB;
            SAA += SumofArrayC;
            SAA();
        }

    }
}
