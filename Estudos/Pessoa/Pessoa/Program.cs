using System;
using System.Dynamic;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPessoas p1, p2;

            p1 = new ClassPessoas();
            p2 = new ClassPessoas();

            Console.WriteLine("Digite o seu nome: ");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu nome: ");
            p2.nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            p2.idade = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Idade: " + p2.idade);

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }
    }
}
