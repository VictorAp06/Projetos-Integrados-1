using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
			// 2. Receba três números do usuário e apresente-os em ordem decrescente.
			Console.WriteLine("Exercício 02");
			Console.WriteLine("Este programa ordena três números em ordem descrescente.");

			String entrada = Console.ReadLine();
			double nro1 = double.Parse(entrada);

			entrada = Console.ReadLine();
			double nro2 = double.Parse(entrada);

			entrada = Console.ReadLine();
			double nro3 = double.Parse(entrada);
		}
    }
}
