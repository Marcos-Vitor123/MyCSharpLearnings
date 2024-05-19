using System;

namespace Enumeradores
{
    enum Season
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
           Season currentSeason = Season.Summer;
           Console.WriteLine($"Estamos na estação: {currentSeason}");

           int seasonIndex = (int)currentSeason;
           Console.WriteLine($"Índice da estação: {seasonIndex}");
        }
    }
}