using System;

namespace Foreach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numeros = [1, 2, 3, 4];

            foreach (string numero in numeros)
            {
                string a = Convert.ToString(numero);
                Console.WriteLine($"{a}");
            }
        }
    } 
}