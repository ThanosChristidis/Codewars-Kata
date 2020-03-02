using System;

    class Program
    {
        public static char Grader(double score) => (score >= 0.9 && score <= 1) ? 'A' : (score >= 0.8 && score < 0.9) ? 'B' : (score >= 0.7 && score < 0.8) ? 'C' : (score >= 0.6 && score < 0.7) ? 'D' : 'F';

        //public static char Grader1(double v) => v > 1 || v < 0.6 ? 'F' : v >= 0.9 ? 'A' : v >= 0.8 ? 'B' : v >= 0.7 ? 'C' : 'D';
    }

