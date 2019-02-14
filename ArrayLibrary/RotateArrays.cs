using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class RotateArrays
    {
        public void RotateArray(string direction, int places, int [] Array)
        {
            int[] AArray = new int [Array.Length];

            if (direction == "Left" || direction == "left")
            {
                int Aelement = 0;

                for (int element = places; element < Array.Length; element++)
                {
                    AArray[Aelement] = Array[element];
                    Aelement++;
                }

                for (int element = 0; element < places; element++)
                {
                    AArray[Aelement] = Array[element];
                    Aelement++;
                }

                int count = 0;
                foreach (int x in AArray)
                {
                    Console.WriteLine($"Element[{count}]: {x}");
                    count++;

                }

            }
            else if (direction == "Right" || direction == "right")
            {
                int Aelement = places;

                for (int element = 0; element < Array.Length - places; element++)
                {
                    AArray[Aelement] = Array[element];
                    Aelement++;
                }

                Aelement = 0;

                for (int element = Array.Length - places; element < Array.Length; element++)
                {
                    AArray[Aelement] = Array[element];
                    Aelement++;
                }

                int count = 0;
                foreach (int x in AArray)
                {
                    Console.WriteLine($"Element[{count}]: {x}");
                    count++;
                }
            }
        }
    }
}
