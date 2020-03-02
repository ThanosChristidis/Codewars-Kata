using System;


    class Program
    {

        public static int Divisors1(int n)
        {
            
            var numberOfDivisors = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    numberOfDivisors++;
                }
            }
            return numberOfDivisors;
        }
        public static int Divisors2(int n)
        {
            var list = new List<int>();
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            }
            return list.Count;
        }
            
    }

