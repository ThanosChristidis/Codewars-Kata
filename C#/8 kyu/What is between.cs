using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {   //First Solution
        public static int[] Between(int a,int b)
        {
            List<int> betweenNumber = new List<int>();
            for (int i = a; i <= b ; i++)
            {
                betweenNumber.Add(i);
            }
            return betweenNumber.ToArray();
        }
        //Second Solution
        public static int[] Between1(int a, int b) => Enumerable.Range(a, b - a + 1).ToArray();

    }
    

