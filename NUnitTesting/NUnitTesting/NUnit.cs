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
            String bin = "";
            Console.Write("Binary of " + n + " is ");
            while (n > 0)                         //finding the binary number
            {
                bin = n % 2 + bin;
                n = n / 2;
            }
            Console.WriteLine(bin);
            NUnit.swapnibble(bin);
        }
        public static void swapnibble(string binary)
        {
            while (binary.Length < 8)                  //So that we can get a 8 digit binary code
            {
                binary = "0" + binary;
            }
            Console.WriteLine(binary);
            String swap = binary.Substring(4, 4) + binary.Substring(0, 4);          //substring function to swap the nibbles
            Console.WriteLine("Swapped binary is " + swap);
            NUnit.toDecimal(swap);
        }
        public static void toDecimal(string swapped)
        {
            int binary = Convert.ToInt32(swapped);                      //converting swapped string to integer format
            int Decimal = 0;
            int n = 0;                                                      //power of two for coverting to decimal
            while (binary != 0)                                    //converting to decimal
            {
                int deci = (int)Math.Pow(2, n) * (binary % 10);
                Decimal = Decimal + deci;
                binary = binary / 10;
                n++;
            }
            Console.WriteLine("Decimal for " + swapped + " is " + Decimal);
        }
    }
}