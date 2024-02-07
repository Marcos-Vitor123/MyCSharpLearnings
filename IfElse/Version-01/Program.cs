using System;

namespace IfElse 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numero = 100;

            if (numero > 50)
            {
                Console.WriteLine("O número é maior que 50.");
            }
            else
            {
                Console.WriteLine("O número não é maior que 50.");
            }
        }
    }
}