using System;

/*
Description:
Write function bmi that calculates body mass index (bmi = weight / height ^ 2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
Kata Link:
https://www.codewars.com/kata/57a429e253ba3381850000fb
*/
    class Program
    {
        //first solution
        public static string Bmi(double weight, double height)
        {
            if (weight / (Math.Pow(height, 2)) <= 18.5)
            {
                return "Underweight";
            }
            else if (weight / (Math.Pow(height, 2)) <= 25.0)
            {
                return "Normal";
            }
            else if (weight / (Math.Pow(height, 2)) <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        //second solution
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (Math.Pow(height, 2));
            return bmi <= 18.5 ? "Underweight" : bmi <= 25.0 ? "Normal" : bmi <= 30.0 ? "Overweight" : "Obese";
        }
}


