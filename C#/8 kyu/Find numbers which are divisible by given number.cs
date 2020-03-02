using System;
using System.Collections.Generic;

//description

//Complete the function which takes two arguments and returns all numbers which are divisible 

//by the given divisor.First argument is an array of numbers and the second is the divisor.


//Example
//DivisibleBy(new int[]{ 1, 2, 3, 4, 5, 6}, 2) == new int[] {2, 4, 6}

public class Kata
{
    public static int[] DivisibleBy(int[] numbers, int divisor)
    {
        List<int> nums = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0) { nums.Add(numbers[i]); }
        }
        return nums.ToArray();
    }
}
