using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//description:

//Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.

namespace CovertBooleanValuesToString
{
    class Program
    {
        public static string boolToWord(bool word) => word.ToString().Replace("True", "Yes").Replace("False", "No");
        
        static void Main(string[] args)
        {
            bool word=true;
            Console.WriteLine(boolToWord(word));
        }
    }
}
