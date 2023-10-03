using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, double> productNPrice = new Dictionary<string, double>();
            Dictionary<string, int> productNquantity = new Dictionary<string, int>();
            while (input[0] != "buy")
            {
                if (!productNPrice.ContainsKey(input[0])) 
                {
                    productNPrice.Add(input[0], double.Parse(input[1]));
                    productNquantity.Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    productNPrice[input[0]] = double.Parse(input[1]);
                    productNquantity[input[0]] += int.Parse(input[2]);
                }
                input = Console.ReadLine().Split(' ');
            }
            Dictionary<string, double> total = new Dictionary<string, double>();
            foreach (var product in productNPrice)
            {
                foreach (var quantity in productNquantity) 
                {
                    if (product.Key == quantity.Key)
                    {
                        total.Add(quantity.Key, product.Value * quantity.Value);
                    }
                }
            }
            foreach (var totalPrice in total)
            {
                Console.WriteLine($"{totalPrice.Key:f2} -> {totalPrice.Value:f2}");
            }
        }
    }
}
