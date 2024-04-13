using _03BasicOOPSuppliers.Models;
using System;
using System.Collections.Generic;

namespace _03BasicOOPSuppliers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var products = new List<Product>
            {
                new Product("Product 1", 20, 50),
                new Product("Product 2", 10, 100)
            };

            var supplier1 = new Supplier("Supplier 1", products, 25);
            var supplier2 = new Supplier("Supplier 2", products, 50);

            supplier1.ApplyPricePolicy();
            supplier2.ApplyPricePolicy();

            Console.WriteLine(supplier1);
            Console.WriteLine();
            Console.WriteLine(supplier2);
        }
    }
}