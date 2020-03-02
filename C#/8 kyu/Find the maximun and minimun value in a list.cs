using System;
using System.Collections.Generic;
using System.Linq;

//description

//Your task is to make two functions, max and min(maximum and minimum in PHP and Python) 

/*that take a(n) array/vector of integers list as input and outputs, respectively, the largest and lowest number in that array/vector.*/

//# Examples

//max({4,6,2,1,9,63,-134,566}) returns 566
//min({ -52, 56, 30, 29, -54, 0, -110}) returns -110
//max({ 5}) returns 5
//min({ 42, 54, 65, 87, 0}) returns 0

namespace Find_the_maximun_and_minimun_value_in_a_list
{
    class Program
    {
        //first solution
        public int Min(int[] list) => list.Min();

        public int Max(int[] list) => list.Max();

        //second solution
        public int Min(int[] list)
        {
            int least = Int32.MaxValue;

            foreach (var item in list)
            {
                if (item < least)
                    least = item;
            }

            return least;
        }
        public int Max(int[] list)
        {
            int most = Int32.MinValue;

            foreach (var item in list)
            {
                if (item > most)
                    most = item;
            }

            return most;
        }

        
    }
}
