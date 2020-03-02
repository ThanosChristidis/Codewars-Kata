using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


//description

//We have a broken message machine that introduces noise to our incoming messages.We know that our messages 
    
//can't be written using %$&/#·@|º\ª and white characters (like spaces or tabs). 

//Unfortunately our machine introduces noise, which means that our message arrives with characters like: %$&/#·@|º\ª within our original message.

//Your mission is to write a function which removes this noise from the message.

//Notice that noise can only be
//%$&/#·@|º\ª
//charaters, other characteres are not considered noise

    class Program
    {
        //first solution
        public static string removeNoise1(string equation) => Regex.Replace(equation, @"[%$&/#·@|º\\ª]", string.Empty);
        
        //second solution
        public static string removeNoise2(string equation)
        {
            string word = "";
            List<char> charList = new List<char>();
            charList.AddRange(equation);

            List<char> newCharList = new List<char>();

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] != '%' && charList[i] != '$' && charList[i] != '&' && charList[i] != '/' && charList[i] != '#' && charList[i] != '·' &&
                    charList[i] != '@' && charList[i] != '|' && charList[i] != 'º' && charList[i] != '\\' && charList[i] != 'ª')
                {
                    newCharList.Add(charList[i]);
                }
            }
            foreach (var item in newCharList)
            {
                word += item;
            }
            return word;
        }

    }

