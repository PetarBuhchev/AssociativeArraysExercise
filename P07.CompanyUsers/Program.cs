using System;
using System.Collections.Generic;

namespace P07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> companyInfo = new Dictionary<string,List<string>>();
            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End") 
            {
                if (!companyInfo.ContainsKey(input[0])) 
                {
                    companyInfo.Add(input[0], new List<string>());
                    companyInfo[input[0]].Add(input[1]);
                }
                else
                {
                    bool exist = false;
                    foreach (var company in companyInfo)
                    {
                        if (company.Key == input[0])
                        {
                            foreach (var employee in company.Value)
                            {
                                if (employee == input[1])
                                {
                                    exist = true;
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    if (!exist) 
                    {
                        companyInfo[input[0]].Add(input[1]);
                    }
                }
                input = Console.ReadLine().Split(" -> ");
            }
            foreach (var company in companyInfo)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value) 
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
