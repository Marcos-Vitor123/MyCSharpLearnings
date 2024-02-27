using System;

namespace ClassePrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a opção do operador desejado: ");
            Console.Write("1 - Somar");
            Console.Write("2 - Subtrair");
            Console.Write("3 - Multiplicar");
            Console.Write("4 - Dividir");
            int operador = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
        }
    }
}