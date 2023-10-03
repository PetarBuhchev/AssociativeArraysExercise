using System;
using System.Collections.Generic;

namespace P06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentNtotalGrades = new Dictionary<string, double>();
            Dictionary<string, int> studentNamountStudent = new Dictionary<string, int>();

            for (int i = 0; i < n; i++) 
            {
                List<string> strings = new List<string>();
                strings.Add(Console.ReadLine());
                strings.Add(Console.ReadLine());

                if (!studentNamountStudent.ContainsKey(strings[0]))
                {
                    studentNtotalGrades.Add(strings[0], double.Parse(strings[1]));
                    studentNamountStudent.Add(strings[0], 1);
                }
                else
                {
                    studentNtotalGrades[strings[0]] += double.Parse(strings[1]);
                    studentNamountStudent[strings[0]]++;
                }
            }
            foreach (var studentNgrade in studentNtotalGrades)
            {
                foreach (var stutendNamount in studentNamountStudent)
                {
                    if (studentNgrade.Key == stutendNamount.Key)
                    {
                        if ((studentNgrade.Value / stutendNamount.Value) >= 4.5)
                        {
                        Console.WriteLine($"{studentNgrade.Key:f2} -> {studentNgrade.Value/stutendNamount.Value:f2}");
                        }
                    }
                }
            }
        }
    }
}
