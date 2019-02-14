using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class MeanofArrays
    {
        delegate void MeanofAllArrays();

        int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
        int[] ArrayB = { 1, 3, 5, 7, 9 };
        int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public void MeanofArrayA()
        {
            int NumberofElements = 0;
            int SumofValues = 0;

            for(int count = 1; count <= ArrayA.Length; count++)
            {
                NumberofElements = count;
            }

            foreach (int x in ArrayA)
            {
                SumofValues += x;
            }
            Console.WriteLine($"Mean of ArrayA: {SumofValues / NumberofElements}");
        }

        public void MeanofArrayB()
        {
            int NumberofElements = 0;
            int SumofValues = 0;

            for (int count = 1; count <= ArrayB.Length; count++)
            {
                NumberofElements = count;
            }

            foreach (int x in ArrayB)
            {
                SumofValues += x;
            }
            Console.WriteLine($"Mean of ArrayA: {SumofValues / NumberofElements}");
        }

        public void MeanofArrayC()
        {
            int NumberofElements = 0;
            int SumofValues = 0;

            for (int count = 1; count <= ArrayC.Length; count++)
            {
                NumberofElements = count;
            }

            foreach (int x in ArrayC)
            {
                SumofValues += x;
            }
            Console.WriteLine($"Mean of ArrayA: {Math.Round(((double)SumofValues / NumberofElements), 2)}");
        }

        public void MeanofAllArraysTogether()
        {
            MeanofAllArrays MAA;
            Console.WriteLine("\n----Mean Of Arrays----");
            MAA = MeanofArrayA;
            MAA += MeanofArrayB;
            MAA += MeanofArrayC;
            MAA();
        }
    }
}
