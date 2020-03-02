using System;
using System.Collections.Generic;
using System.Linq;

//description:

//Given an array of integers, return a new array with each value doubled.

//For example:

//[1, 2, 3] --> [2, 4, 6]

//For the beginner, try to use the map method - it comes in very handy quite a lot so is a good one to know.

namespace MultiplyEachElementInAnArray
{
    class Program
    {
        //First Solution
        public static int[] Maps(int[] x) => x.AsEnumerable().Select(item => item * 2).ToArray();

        //Second Solution
        public static int[] Maps(int[] x) => x.Select(item => item * 2).ToArray();

        //Third Solution
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }
    }
}
