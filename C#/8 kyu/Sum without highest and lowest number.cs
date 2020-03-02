using System;
using System.Collections.Generic;
using System.Linq;

//description

//Sum all the numbers of the array(in F# and Haskell you get a list) except the highest and the lowest element (the value, not the index!).
//(The highest/lowest element is respectively only one element at each edge, even if there are more than one with the same value!)

//Example:

//{ 6, 2, 1, 8, 10 } => 16
//{ 1, 1, 11, 2, 3 } => 6

//If array is empty, null or None, or if only 1 Element exists, return 0.


    class Program
    {
        public static int Sum(int[] numbers2) => (numbers2.Length <=1 || numbers2 == null ) ? 0 : numbers2.Sum() - numbers2.Max() - numbers2.Min();
    }

