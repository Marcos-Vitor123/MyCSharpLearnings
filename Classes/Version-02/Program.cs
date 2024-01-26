using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Carro carro = new Carro();
            
            carro.marca = "Ford";
            carro.modelo = "Ford Fusion";
            carro.cor = "Preto";
            carro.ano = 2000;
            carro.velocidade = 300;
            Console.WriteLine($"Marca: {carro.marca}\nModelo: {carro.modelo}\nCor: {carro.cor}\nAno: {carro.ano}\nVelocidade: {carro.velocidade}");
        }
    }

    class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public int velocidade { get; set; } 
    }
}