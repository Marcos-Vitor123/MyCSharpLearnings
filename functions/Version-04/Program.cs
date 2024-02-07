using System;

namespace Functions 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExibirString("abcdefgh");
        }
        public static void ExibirString(string exibirString) // função sem retorno
        {
            Console.WriteLine(exibirString);
        }
    }
}

