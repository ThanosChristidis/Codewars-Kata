using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//description:

//Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. For example:

//  SumDigits(10)  // Returns 1
//  SumDigits(99)  // Returns 18
//  SumDigits(-32) // Returns 5
//Let's assume that all numbers in the input will be integer values.

namespace Summing_a_number_s_digits
{
    class Program
    {
        //first solution
        public static int SumDigits(int number) => Math.Abs(number).ToString().Sum(c => c -'0');
        
        //second solution
        public static int SumDigits(int number)
        {
            int ret = 0;
            foreach (char c in Math.Abs(number).ToString())
            ret += c - '0';
            return ret;
        }
        
    }
}
