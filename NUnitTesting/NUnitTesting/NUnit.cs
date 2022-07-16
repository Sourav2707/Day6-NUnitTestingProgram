using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class NUnit
    {
        public static void Test(int n)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] num = new int[8];


            for (int i = 0; i < 8; i++)
            {
                if (n >= notes[i])
                {
                    num[i] = n / notes[i];
                    n -= num[i] * notes[i];
                }
            }

            Console.WriteLine("Minimum Notes required");
            for (int i = 0; i < 8; i++)
            {
                if (num[i] != 0)
                {
                    Console.WriteLine($"{notes[i]} RS note x {num[i]} numbers");
                }
            }
        }
    }
}
