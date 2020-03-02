using System;
using System.Collections.Generic;
using System.Linq;

// description

    //Simple, remove the spaces from the string, then return the resultant string.

    class Program
    {
        public static string NoSpace(string input) => input.Replace(" ", "");
        public static string NoSpace(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() != " ")
                {
                    output += input[i];
                }
            }
            return output;
        }
  
    }

