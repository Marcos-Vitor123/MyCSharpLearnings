using System;

namespace ConversaoImplicita
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            sbyte sbyteSinalNegativo = -128; // Assinado de 8 bits
            sbyte sbyteSinalPositivo = 127; 
            Console.WriteLine(sbyteSinalNegativo);
            Console.WriteLine(sbyteSinalPositivo);

            short sbyteSinalNegativoParaShort = sbyteSinalNegativo; // Conversão Implícita
            short sbyteSinalPositivoParaShort = sbyteSinalPositivo; 
            Console.WriteLine(sbyteSinalNegativoParaShort);
            Console.WriteLine(sbyteSinalPositivoParaShort);

            short shortSinalNegativo = -32768; // Assinado de 16 bits
            short shortSinalPositivo = 32767;
            Console.WriteLine(shortSinalNegativo);
            Console.WriteLine(shortSinalPositivo);

            //int n2n3 = n2; // Conversão Implícita
            //Console.WriteLine(n2n3);

            //int n3 = 1234567890;
            //Console.WriteLine(n3);
            //long n3n4 = n3; // Conversão Implícita
            //Console.WriteLine(n3n4);

            //long numerosCurtoParaLongo = numerosCurto; // Conversão Implícita
            //int numerosLongoParaCurto = (int)numerosCurtoParaLongo; // Conversão Explícita

            //Console.WriteLine(numerosCurtoParaLongo);
            //Console.WriteLine(numerosLongoParaCurto);
        }
    }
}