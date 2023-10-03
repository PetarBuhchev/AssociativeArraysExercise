using System;
using System.Collections.Generic;

namespace P04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> userCar = new Dictionary<string, string>();
           
            for (int i = 0; i < n; i++)
            {
            string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "register")
                {
                    if (userCar.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else 
                    {
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                        userCar.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!userCar.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        userCar.Remove(input[1]);
                    }
                }
            }
            foreach (var user in userCar)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
