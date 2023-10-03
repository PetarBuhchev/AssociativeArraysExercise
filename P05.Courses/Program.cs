using System;
using System.Collections.Generic;

namespace P05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesNstudents = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" : ");

            while (input[0] != "end")
            {
                if (!coursesNstudents.ContainsKey(input[0])) 
                {
                    coursesNstudents.Add(input[0], new List<string>());
                    coursesNstudents[input[0]].Add(input[1]);
                }
                else 
                {
                    coursesNstudents[input[0]].Add(input[1]);
                }
                input = Console.ReadLine().Split(" : ");
            }
            foreach (var courses in coursesNstudents)
            {
                Console.WriteLine($"{courses.Key}: {courses.Value.Count}");
                foreach (string student in courses.Value) 
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
