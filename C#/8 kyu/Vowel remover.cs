using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//description:

//Create a function called shortcut to remove all the lowercase vowels in a given string.

//Examples
//Shortcut("codewars") # --> cdwrs
//Shortcut("goodbye")  # --> gdby
//Don't worry about uppercase vowels.

    class Program
    {
        //first solution
        public static string Shortcut(string input) => Regex.Replace(input, @"[aeiou]", string.Empty);
        
        //second solution
        public static string Shortcut1(string input)
        {
            string word = "";

            List<char> charList = new List<char>();

            charList.AddRange(input);

            List<char> newCharList = new List<char>();

            for (int i = 0; i < charList.Count; i++)
            {
                if(charList[i]!='a' && charList[i] !='e' && charList[i] != 'i' && charList[i] != 'o' && charList[i] != 'u')
                {
                    newCharList.Add(charList[i]);
                }
            }
            foreach (char item in newCharList)
            {
                word += item;
            }
            return word;
        }
    }

