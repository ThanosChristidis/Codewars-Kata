using System;
using System.Collections.Generic;
using System.Linq;

//description

//Complete the solution so that it reverses the string value passed into it.

//Kata.Solution("world") //returns "dlrow"


    class Program
    {
        //first solution
        public static string Solution(string str)
        {
            char[] charArray = str.ToCharArray();
            string reverse = "";

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
        //second solution
        public static string Solution(string str)
        {
            List<char> charList = new List<char>();
            charList.AddRange(str);
            charList.Reverse();

            string word = null;

            foreach (var item in charList)
            {
                word += item;
            }
            return word;
        }
        //third solution
        public static string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }

