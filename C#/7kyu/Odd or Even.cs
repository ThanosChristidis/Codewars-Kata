﻿using System;
using System.Collections.Generic;
using System.Linq;

//description

//Task:
//Given a list of numbers, determine whether the sum of its elements is odd or even.

//Give your answer as a string matching "odd" or "even".

//If the input array is empty consider it as: [0] (array with a zero).

//Example:
//odd_or_even([0])          ==  "even"
//odd_or_even([0, 1, 4])    ==  "odd"
//odd_or_even([0, -1, -5])  ==  "even"

    class Program
    {
        public static string OddOrEven(int[] array)
        {
            return (array.Sum() % 2 == 0) ? "Even" : "Odd";
        }
    }

