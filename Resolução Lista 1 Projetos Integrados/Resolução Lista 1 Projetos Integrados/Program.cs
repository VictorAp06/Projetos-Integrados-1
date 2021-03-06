using System;

namespace Resolução_Lista_1_Projetos_Integrados
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Receba dois números do usuário e imprima uma mensagem na tela com o
            // quociente e o resto da divisão entre eles.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Este programa calcula o quociente e o resto da divisão de dois números \n" +
                "Entre com o primeiro número: ");

            string entrada = Console.ReadLine();

            double nro1 = double.Parse(entrada);

            entrada = Console.ReadLine();

            double nro2 = double.Parse(entrada);

            Console.WriteLine("O número 1 digitado foi: {0}", nro1);
            Console.WriteLine("O número 2 digitado foi: {0}", nro2);

            double result = nro1 / nro2;

            Console.WriteLine("Resultado Divisão nro1 / nro2 = {0}", result);

            Console.Read();//usado para o console não fechar
        }
    }
}
