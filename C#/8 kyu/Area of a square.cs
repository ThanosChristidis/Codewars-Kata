using System;


//description

//Complete the function that calculates the area of the red square, when the length of the circular arc A is given as the input.Return the result rounded to two decimals.

class Program
    {
        public static double SquareArea(double A) => Math.Round(Math.Pow((2 * A) / Math.PI, 2), 2);
    }

