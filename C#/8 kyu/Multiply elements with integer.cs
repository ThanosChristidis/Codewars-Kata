using System;

namespace MultiplyElementsWithInteger
{
    public class Kata
    {
        public static int[] MultiplyAll(int[] array)
        {
            int x = 2;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * x;
            }
            return array;
        }
    }
}
