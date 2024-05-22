using System;

namespace ConversaoImplicita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            sbyte numerosDoisDigitos = 12;
            short numerosQuatroDigitos = 1234;
            int numerosCurto = 1234567890;
            //long numerosCurtoParaLongo = numerosCurto; // Conversão Implícita
            //int numerosLongoParaCurto = (int)numerosCurtoParaLongo; // Conversão Explícita

            Console.WriteLine(numerosDoisDigitos);
            Console.WriteLine(numerosQuatroDigitos);
            Console.WriteLine(numerosCurto);
            //Console.WriteLine(numerosCurtoParaLongo);
            //Console.WriteLine(numerosLongoParaCurto);
        }
    }
}