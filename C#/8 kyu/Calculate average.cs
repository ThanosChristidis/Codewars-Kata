using System;
using System.Linq;

//description

//Write function avg which calculates average of numbers in given list.

class AverageSolution
{
    //first solution
    public static double FindAverage(double[] array) => array.Average();

    //second solution

    public static double FindAverage(double[] array)
    {
        double average;
        double sum = array.Sum();
        return average = sum / array.Length;
    }
} 
}