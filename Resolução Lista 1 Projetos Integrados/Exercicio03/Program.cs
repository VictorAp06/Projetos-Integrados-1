using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Elabore um programa que receba um número inteiro representando uma
            //quantidade de segundos, e então calcule quantas horas e minutos esta quantidade
            //de segundos representa, apresentando o resultado em uma mensagem.

            Console.WriteLine("Bem vindo! \n Este programa recebe um valor numérico em segundos e retorna a quantidade de horas e minutos este valor de entrada representa.");
            Console.WriteLine("Insira o valor: ");

            String entrada = Console.ReadLine();

            int segundo = int.Parse(entrada);

            int hora = (int)(segundo / (60 * 60));
            int minuto = (int)((segundo - (hora*60*60))/60);
            segundo = (int)(segundo - (hora * 60 * 60) - (minuto * 60));

            Console.WriteLine("\nHora: " + hora + "\nMinuto: " + minuto + "\nSegundo: " + segundo);

            Console.Read();

        }
    }
}
