﻿using System;
using System.Collections.Generic;
using System.Linq;

//description

//Task
//A boy is walking a long way from school to his home.To make the walk more fun he decides to add up all the numbers of the houses that he passes by during his walk.Unfortunately, 

//not all of the houses have numbers written on them, and on top of that the boy is regularly taking turns to change streets, so the numbers don't appear to him in any particular order.


//At some point during the walk the boy encounters a house with number 0 written on it, which surprises him so much that he stops adding numbers to his total right after seeing that house.


//For the given sequence of houses determine the sum that the boy will get. It is guaranteed that there will always be at least one 0 house on the path.


//Example
//For inputArray = [5, 1, 2, 3, 0, 1, 5, 0, 2], the output should be 11.


//The answer was obtained as 5 + 1 + 2 + 3 = 11.


//Input/Output
//[input] integer array inputArray


//Constraints: 5 ≤ inputArray.length ≤ 50, 0 ≤ inputArray[i] ≤ 10.


//[output] an integer

    class Program
    {
        //first solution
        public static int HouseNumbersSum(int[] inputArray) => inputArray.TakeWhile(h => h != 0).Sum();
        
        // second solution
        public static int HouseNumbersSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 0) break;
                else sum += inputArray[i];
            }
            return sum;
        }
        
        //third solution
        public static int HouseNumbersSum(int[] inputArray)
        {
            int sum = 0;
            foreach (int num in inputArray)
            {
                if (num == 0)
                {
                    break;
                }
                sum += num;
            }
            return sum;
        }
    }

