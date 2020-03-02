using System;

/// <summary>
/// description
/// 
/// Count the number of divisors of a positive integer n.

//Random tests go up to n = 500000.

//Examples
//Kata.Divisors(4)  -> 3 -- 1, 2, 4
//Kata.Divisors(5)  -> 2 -- 1, 5
//Kata.Divisors(12) -> 6 -- 1, 2, 3, 4, 6, 12
//Kata.Divisors(30) -> 8 -- 1, 2, 3, 5, 6, 10, 15, 30
/// </summary>

public class Kata
{
    public static int Divisors(int n)
    {
        int count = 0;
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (n / i == i) { count++; }
                else { count += 2; }
            }
        }
        return count;
    }
}

