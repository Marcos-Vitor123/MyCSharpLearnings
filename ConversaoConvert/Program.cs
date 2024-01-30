using System;

namespace ConversaoConvert
{
    internal class Programa
    {
        private static void Main(string[] args)
        {
            int inteiro = 123;
            string str = "1000";
            bool fal = false;
            char caracter = 'A';


            double ConversaoDouble = Convert.ToDouble(inteiro);
            string ConversaoString = Convert.ToString(inteiro);
            decimal ConversaoDecimal = Convert.ToDecimal(inteiro);
            int ConversaoInt = Convert.ToInt32(str);
            string ConversaoBoolString = Convert.ToString(fal);
            string ConversaoCharString = Convert.ToString(caracter);
            float conversaoFloat = float.Parse(str);

            Console.WriteLine($"Convertido de inteiro para double: {ConversaoDouble}");
            Console.WriteLine($"Convertido de inteiro para string: {ConversaoString}");
            Console.WriteLine($"Convertido de inteiro para decimal: {ConversaoDecimal}");
            Console.WriteLine($"Convertido de string para inteiro: {ConversaoInt}");
            Console.WriteLine($"Convertido de bool para string: {ConversaoBoolString}");
            Console.WriteLine($"Convertido de char para string: {ConversaoCharString}");
            Console.WriteLine($"Convertido de char para string: {conversaoFloat}");
        }
    }
}