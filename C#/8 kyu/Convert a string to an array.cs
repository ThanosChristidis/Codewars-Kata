using System;

//description:

//Write a function to split a string and convert it into an array of words.For example:

//"Robin Singh" ==> ["Robin", "Singh"]

//"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]

namespace Solution
{
    public class Solution
    {
        public static string[] StringToArray(string str) => str.Split(" ".ToCharArray());
    }
}