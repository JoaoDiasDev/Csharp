﻿using LambdaDelegatesLINQ3.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(ProductTest);

foreach (Product p in list)
{
    Console.WriteLine(p);
}

static bool ProductTest(Product p)
{
    return p.Price >= 100.0;
}