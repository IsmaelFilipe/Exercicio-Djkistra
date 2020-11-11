using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            Console.WriteLine("Informe os dados das linhas da matriz:  ");

            for(int l = 0; l < 4; l++)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.Write($"Informe o valor da posicao[{l + 1},{c + 1}]: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\nMatriz: ");
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{matriz[l,c]}\t");
                }
                Console.Write("\n");
            }
        }
    }
}
