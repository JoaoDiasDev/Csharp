using LINQLambdaSQLPratice1.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

while (string.IsNullOrEmpty(path))
{
    Console.WriteLine("Digite o caminho correto");
    Console.Write("Enter full file path: ");
    path = Console.ReadLine();
}

List<Product> list = new List<Product>();

if (string.IsNullOrEmpty(path))
{
    
}

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        list.Add(new Product(name, price));
    }
}

var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach (string name in names)
{
    Console.WriteLine(name);
}