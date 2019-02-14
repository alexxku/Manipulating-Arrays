using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class CountArrays 
    {
        delegate void CountofAllArays();

        int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
        int[] ArrayB = { 1, 3, 5, 7, 9 };
        int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
        
        public void CountArrayA()
        {
            int totalcount = 0;

            for(int count = 1; count <= ArrayA.Length; count++)
            {
                totalcount = count;
            }
            Console.WriteLine($"Number of Elements on ArrayA: {totalcount}");
        }

        public void CountArrayB()
        {
            int totalcount = 0;

            for (int count = 1; count <= ArrayB.Length; count++)
            {
                totalcount = count;
            }
            Console.WriteLine($"Number of Elements on ArrayB: {totalcount}");
        }

        public void CountArrayC()
        {
            int totalcount = 0;

            for (int count = 1; count <= ArrayC.Length; count++)
            {
                totalcount = count;
            }
            Console.WriteLine($"Number of Elements on ArrayC: {totalcount}");
        }
        
        public void CountArraysTogether()
        {
            CountofAllArays CAA;
            Console.WriteLine("----Counts----");
            CAA = CountArrayA;
            CAA += CountArrayB;
            CAA += CountArrayC;
            CAA();
        }
    }
}
