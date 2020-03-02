using System;
using System.Linq;

//description

//Convert number to reversed array of digits
//Given a random number:

//C#: long;
//C++: unsigned long;
//You have to return the digits of this number within an array in reverse order.

//Example:
//348597 => [7,9,5,8,4,3]

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n) => n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
    }
}
