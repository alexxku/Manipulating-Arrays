using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class ReverseArrays
    {
        public void ReverseArray(int [] Array)
        {
            int count = Array.Length;

            int[] AArray = new int[Array.Length];

            foreach (int x in Array)
            {
                count--;
                AArray[count] = x;
            }

            foreach (int x in AArray)
            {
                Console.WriteLine($"Array's Element {count}: {x}");
                count++;
            }
        }


    }
}
