using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int resultado = Multiplicar(4, 6);

            Console.WriteLine(resultado);
            
            int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
    }
}
