﻿using System;
using System.Collections.Generic;
using System.Linq;

//description:

//    Let's build a matchmaking system that helps discover jobs for developers based on a number of factors.

//One of the simplest, yet most important factors is compensation.As developers we know how much money we need to support our lifestyle, 

//so we generally have a rough idea of the minimum salary we would be satisfied with.

//Let's give this a try. We'll create a function match which takes a candidate and a job, which will either return a boolean indicating 

//whether the job is a valid match for the candidate.


//A candidate will have a minimum salary, so it will look like this:


//Candidate candidate =
// new Candidate(MinSalary: 120000);
//A job will have a maximum salary, so it will look like this:

//Job job =
//  new Job(MaxSalary: 140000);
//If either the candidate's minimum salary or the job's maximum salary is not present, throw an error.

//For a valid match, the candidate's minimum salary must be less than or equal to the job's maximum salary.

//However, let's also include 10% wiggle room (deducted from the candidate's minimum salary) 

//in case the candidate is a rockstar who enjoys programming on Codewars in their spare time. 
    
//The company offering the job may be able to work something out.


namespace JobMatching
{
    class Program
    {
        public static bool Match(Candidate c, Job j) => c.MinSalary == 0 || j.MaxSalary == 0 ? throw new NotImplementedException() : c.MinSalary * 0.9 <= j.MaxSalary;
        
        static void Main(string[] args)
        {
            Candidate c = new Candidate(MinSalary:120000);
            Job j = new Job(MaxSalary:0);
            Console.WriteLine(Match(c,j));
        }
    }
    public class Candidate
    {
        public int MinSalary { get; set; }
        public Candidate() { }
        public Candidate(int MinSalary)
        {
            this.MinSalary = MinSalary;
        }
    }
    public class Job
    {
        public int MaxSalary { get; set; }
        public Job() { }
        public Job(int MaxSalary)
        {
           this.MaxSalary = MaxSalary;
        }
    }
    
}
