using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int resultado = soma(2, 3);

            int soma(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(resultado);
        }
    }
}
