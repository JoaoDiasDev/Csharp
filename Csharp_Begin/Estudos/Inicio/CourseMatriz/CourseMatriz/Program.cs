using System;

namespace CourseMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            mat[1, 0] = 4.0;
            mat[1, 1] = 5.0;
            foreach (double obj in mat)
            {
               Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da matriz: " + mat.Length);
            Console.WriteLine("Quantas linhas: " + mat.Rank);
            Console.WriteLine(mat.GetLength(0)); // Quantidade de linhas matriz
            Console.WriteLine(mat.GetLength(1)); // Quantidade de colunas matriz
            Console.WriteLine(mat.GetLength(2));
        }
    }
}
