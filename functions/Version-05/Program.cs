using System;

namespace Functions 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string mostrar = NewFunction("Marcos");
            Console.WriteLine(mostrar);
        }

        static string NewFunction(string nome)
        {
            return nome;
        }
    }
}