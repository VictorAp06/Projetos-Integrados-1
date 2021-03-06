using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            // Escreva um programa que imprima todos os números pares menores que N, sendo
            // que N será fornecido pelo usuário.

            Console.WriteLine("Este programa retorna todos os valores pares menores que N. \nEntre com N: ");
            
            String input = Console.ReadLine();
            int n = int.Parse(input);

            for(int i = n; i > 0; i--)
            {
                if((i%2) == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
