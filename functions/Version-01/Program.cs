using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int resultado = Soma(2, 3);

            int Soma(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(resultado);
        }
    }
}

