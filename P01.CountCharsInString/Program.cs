using System;
using System.Collections.Generic;

namespace P01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                if (count.ContainsKey(input[i]))
                {
                    count[input[i]]++;
                }
                else
                {
                    count.Add(input[i], 1);                }
            }
            foreach (var character in count)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
