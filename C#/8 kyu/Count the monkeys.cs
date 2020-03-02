using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Description:

//You take your son to the forest to see the monkeys.You know that there are a certain number there(n), 

//but your son is too young to just appreciate the full number, he has to start counting them from 1.

//As a good parent, you will sit and count with him.Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.

//For example:

//monkeyCount(10) // --> new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
//monkeyCount(1) // --> new int[]{1}


namespace Count_the_monkeys
{
    class Program
    {
        //first solution
        public static int[] MonkeyCount(int n)
        {
            List<int> monkeys = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                monkeys.Add(i);
            }
            return monkeys.ToArray();
        }

        //second solution
        public static int[] MonkeyCount(int n)
        {
            int[] monkeys = new int[n];

            for (int i = 0; i < n; i++)
            {
                monkeys[i] = i + 1;
            }
            return monkeys;
        }

        //third solution
        public static int[] MonkeyCount(int n)
        {
            int[] monkeys = new int[n];

            for (int i = 0; i < n; i++)
            {
                monkeys.Count();
            }
            return monkeys;
        }

        //fourth solution
        public static int[] MonkeyCount1(int n) => Enumerable.Range(1, n).ToArray();
        
    }
}
