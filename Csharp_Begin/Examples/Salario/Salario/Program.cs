using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassSalario p1, p2;

            p1 = new ClassSalario();
            p2 = new ClassSalario();
            
            Console.WriteLine("Digite seu nome: ");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Digite seu salario: ");
            p1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            p2.nome = Console.ReadLine();

            Console.WriteLine("Digite seu salario: ");
            p2.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Salário: " + p1.salario);
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Salário: " + p2.salario);

            double resultado = ((p1.salario + p2.salario) / 2);

            Console.WriteLine("Salario médio = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
