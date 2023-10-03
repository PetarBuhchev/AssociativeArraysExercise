using System;
using System.Collections.Generic;

namespace P02.AminerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listInput = new List<string>();
            string input = Console.ReadLine();

            while (input != "stop")
            {
                listInput.Add(input);
                input = Console.ReadLine();
            }
            var resource = new Dictionary<string, int>();

            for (int i = 0; i < listInput.Count; i+=2) // type of resource
            {
                for (int j = 1; j < listInput.Count; j+=2) // amount of resource
                {
                    if (resource.ContainsKey(listInput[i]))
                    {
                        resource[listInput[i]] += int.Parse(listInput[j]);
                        listInput.RemoveAt(i);
                        listInput.RemoveAt(j-1);
                        i -= 2;
                        j -= 2;
                        break;
                    }
                    else
                    {
                        resource.Add(listInput[i], int.Parse(listInput[j]));
                        listInput.RemoveAt(i);
                        listInput.RemoveAt(j-1);
                        i -= 2;
                        j -= 2;
                        break;
                    }
                }
            }
            foreach (var resourceType in resource)
            {
                Console.WriteLine($"{resourceType.Key} -> {resourceType.Value}");
            }
        }
    }
}
