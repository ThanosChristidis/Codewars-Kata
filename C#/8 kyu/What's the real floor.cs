using System;

//Description:

//Americans are odd people: in their buildings, the first floor is actually the ground floor and there is no 13th floor('cause of superstition).

//Write a function that given an American floor (passed as an integer) returns the real floor.
//Moreover, your function should work for basement floors too: just return the same value as the passed one.

//Usage Examples
//GetRealFloor(1) == 0 
//GetRealFloor(0) == 0 // Special case to please Europeans
//GetRealFloor(5) == 4
//GetRealFloor(15) == 13
//GetRealFloor(-3) == -3

    class Program
    {
        public static int GetRealFloor(int n) => n <= 0 ? n : n <= 13 ? n - 1 : n - 2;

    }

