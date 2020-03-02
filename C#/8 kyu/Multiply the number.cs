using System;

//Description:
//Jack really likes his number five: the trick here is that you have to multiply each number by 5 raised to the number of digits of each numbers, so, for example:

//multiply(3)==15
//multiply(10)==250
//multiply(200)==25000
//multiply(0)==0
//multiply(-3)==-15

public class Kata
{
    public static int Multiply(int number)
    {
        if (number >= -9 && number <= 9) return number * 5;
        else if ((number >= -99) && (number <= -10) || (number <= 99) && (number >= 10)) return number * (int)(Math.Pow(5, 2));
        else if ((number >= -999) && (number <= -100) || (number <= 999) && (number >= 100)) return number * (int)(Math.Pow(5, 3));
        else if ((number >= -9999) && (number <= -1000) || (number <= 9999) && (number >= 1000)) return number * (int)(Math.Pow(5, 4));
        else return (int)(Math.Pow(5, 5));
    }
}
