using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class SortArray
    {
        static int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public void Sort(int [] Array)
        {
            int nextelement = 1;
            int movingValue = 0;
            for(int element = 0; element < Array.Length;)
            {
                if (Array[element] > Array[nextelement])
                {
                    movingValue = Array[element];
                    Array[element] = Array[nextelement];
                    Array[nextelement] = movingValue;
                    element = 0;
                    nextelement = 1;
                 
                }
                else
                {
                    Array[nextelement] = Array[nextelement];
                    element++;
                    nextelement++;
                    if(nextelement == Array.Length)
                    {
                        break;
                    }
                }        
            }

            int sortedelement = 0;

            Console.WriteLine("\n----Sorted Array----");

            foreach(int x in Array)
            {
                Console.WriteLine($"Array's Element[{sortedelement}]: {x}");
                sortedelement++;
            }
        }

    }
}
