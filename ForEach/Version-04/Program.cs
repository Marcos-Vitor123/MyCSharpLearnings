using System;

namespace Foreach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<float> numeros = [1.0f, 2.0f, 3.0f, 4.0f];

            foreach(float numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}