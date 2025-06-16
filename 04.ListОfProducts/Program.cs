/*
 * 04.ListОfProducts
 */

using System;
using System.Collections.Generic;

namespace _04.ListОfProducts;

class Program
{
    static void Main()
    {
        int productsCount = int.Parse(Console.ReadLine() ?? "6");
        List<string> products = new(productsCount);

        for (int i = 0; i < productsCount; i++)
        {
            products.Add(Console.ReadLine() ?? "666");
        }

        products.Sort();

        int leadingDigit = 1;
        int productIndex = 0;
        products.ForEach(x => Console.WriteLine($"{leadingDigit++}.{products[productIndex++]}"));
    }
}