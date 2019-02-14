using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Manipulating_Arrays
{
    class Program
    {
        static int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
        static int[] ArrayB = { 1, 3, 5, 7, 9 };
        static int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        static void Main(string[] args)
        {
            CountArrays CArrays = new CountArrays();

            CArrays.CountArraysTogether();

            SumofArrays SArrays = new SumofArrays();

            SArrays.SumofAllArraysTogether();

            MeanofArrays MArrays = new MeanofArrays();

            MArrays.MeanofAllArraysTogether();

            ReverseArrays RArrays = new ReverseArrays();
            Console.WriteLine("\n----Reverse of Arrays----");
            Console.WriteLine("ArrayA");
            RArrays.ReverseArray(ArrayA);
            Console.WriteLine("ArrayB");
            RArrays.ReverseArray(ArrayB);
            Console.WriteLine("ArrayC");
            RArrays.ReverseArray(ArrayC);
            RotateArrays ROArrays = new RotateArrays();

            Console.WriteLine("----Rotate Array----");
            Console.WriteLine("ArrayA");
            ROArrays.RotateArray("Left", 2, ArrayA);
            Console.WriteLine("ArrayB");
            ROArrays.RotateArray("Right", 2, ArrayB);
            Console.WriteLine("ArrayC");
            ROArrays.RotateArray("Left", 4, ArrayC);

            SortArray SArray = new SortArray();
            SArray.Sort(ArrayC);

            Console.ReadLine();

        }

    }
}
