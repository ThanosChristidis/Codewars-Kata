using System;
using System.Collections.Generic;
using System.Linq;

//description

//Welcome.In this kata, you are asked to square every digit of a number.


//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.


//Note: The function accepts an integer and returns an integer

    class Program
    {
        // first solution
        public static int SquareDigits(int n)
        {
            string squared = "";
            int square_digits = 0;

            foreach (char c in n.ToString())
            {
                int digit = int.Parse(c.ToString());
                int square = digit * digit;
                squared += square.ToString();
            }
            return square_digits = int.Parse(squared);
        }

        // second solution
        public static int SquareDigits1(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }

        // third solution
        public static int SquareDigits2(int n)
        {
            List<char> charList = new List<char>();

            charList.AddRange(n.ToString());

            string sNum = null;
            double dNum = 0;

            foreach (var item in charList)
            {
                dNum = Convert.ToDouble(item.ToString());
                dNum = Math.Pow(dNum, 2);
                sNum += dNum;
            }

            return Convert.ToInt32(sNum);
        }
    }

