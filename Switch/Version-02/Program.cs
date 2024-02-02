using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            switch(numero)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"Você digitou: {numero}");
                    break;
                default:
                    Console.WriteLine($"Número inválido!");
                    break;
            }
        }
    }
}
