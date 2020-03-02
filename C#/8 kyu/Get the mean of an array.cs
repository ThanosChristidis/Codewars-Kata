using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        //first solution
        public static int GetAverage(int[] marks) => (int)marks.Average();

        //second solution
        public static int GetAverage(int[] marks) => marks.Sum() / marks.Length;
        
    }

