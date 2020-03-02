using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_number_to_reversed_array_of_digits
{
    class Program
    {
        public static long[] Digitize(long n) => n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
        
        public static long[] Digitize1(long n)
        {
            char[] charArray = n.ToString().ToCharArray();
            long[] charToLong = new long[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
                charToLong[i] = Convert.ToInt64(charArray[i]);

            Array.Reverse(charToLong);
            return charToLong;
        }
        public static long[] Digitize2(long n)
        {
            return n.ToString()
                    .Reverse()
                    .Select(t => Convert.ToInt64(t.ToString()))
                    .ToArray();
        }
        static void Main(string[] args)
            {

            }
    }
}
