﻿using System;
using System.Collections.Generic;
using System.Linq;

//description

//You get an array of numbers, return the sum of all of the positives ones.

//Example [1,-4,7,12] => 1 + 7 + 12 = 20


Note: if there is nothing to sum, the sum is default to 0.

    class Program
    {
        public static int PositiveSum(int[] arr) => arr.Where(n => n > 0).Sum();
    }

