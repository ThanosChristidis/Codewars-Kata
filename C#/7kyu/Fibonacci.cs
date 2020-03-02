using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//description:

//Create function fib that returns n'th element of Fibonacci sequence (classic programming task).

namespace Fibonacci
{
    class Program
    {
        //first solution
        public static int fib(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }

        //second solution
        public int fib(int n) => n == 0 ? 0 : n == 1 ? 1 : fib(n - 2) + fib(n - 1);
        
    }
}
