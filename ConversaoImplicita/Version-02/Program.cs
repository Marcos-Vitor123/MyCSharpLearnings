using System;

namespace ConversaoImplicita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            sbyte n1 = 123;
            Console.WriteLine(n1);
            short n1n2 = n1; // Conversão Implícita
            Console.WriteLine(n1n2);

            short n2 = 12345;
            Console.WriteLine(n2);
            int n2n3 = n2; // Conversão Implícita
            Console.WriteLine(n2n3);

            int n3 = 1234567890;
            Console.WriteLine(n3);
            long n3n4 = n3; // Conversão Implícita
            Console.WriteLine(n3n4);

            //long numerosCurtoParaLongo = numerosCurto; // Conversão Implícita
            //int numerosLongoParaCurto = (int)numerosCurtoParaLongo; // Conversão Explícita

            //Console.WriteLine(numerosCurtoParaLongo);
            //Console.WriteLine(numerosLongoParaCurto);
        }
    }
}