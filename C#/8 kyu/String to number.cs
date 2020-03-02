using System;
using System.Collections.Generic;
using System.Linq;

namespace StringToNumber
{

    class Program
    {
        //first solution
        public static int StringToNumber(string str) => int.Parse(str);

        //second solution
        public static int StringToNumber(string str) => Convert.ToInt32(str);

    }
}
