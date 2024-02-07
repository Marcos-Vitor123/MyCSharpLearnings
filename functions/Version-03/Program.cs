using System;

namespace Functions 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int resultado = Multiplicar(4, 6);

            Console.WriteLine(resultado);

            static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
    }
}
