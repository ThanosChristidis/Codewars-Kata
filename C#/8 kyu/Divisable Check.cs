using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisableCheck
{
    class Program
    {
        public static bool is_divide_by(int number, int a, int b) => (number % a==0 && number % b==0) ? true : false;
       
        static void Main(string[] args)
        {

        }
    }
}
