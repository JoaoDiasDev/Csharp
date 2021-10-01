using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Services;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string cr = Console.ReadLine();


            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");

            int n = int.Parse(cr);

            for (int i = 0; i < n; i++) {
                string[] vect = cr.Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list); // <Product> is optional

            Console.WriteLine("Most expensive:");
            Console.WriteLine(p);
        }
    }
}
