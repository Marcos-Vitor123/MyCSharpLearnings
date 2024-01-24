using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           int resultado = Subtrair(5, 10);

           Console.WriteLine(resultado);
        }
        static int Subtrair(int a, int b) // Chamando função fora do main, acrescenta static
        {
            return a - b;
        }
    }
}