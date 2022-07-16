using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class NUnit
    {
        public static double Test(int ch, double convert_into)
        {
            double converted = 0;
            if(ch==1)
            {
               converted= (convert_into* 9 / 5) +32 ;              //deg C to deg F
            }
            else
            {
                converted= (convert_into -32)*5/9;                  //deg F to deg C
            }
            return converted;
        }
     }
}
