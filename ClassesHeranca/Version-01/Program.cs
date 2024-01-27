using System;

namespace ClassesHeranca
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro();
            Animal meuAnimal = new Animal();

            meuCachorro.Nome = "Rondom";
            Console.WriteLine($"Nome: {meuCachorro.Nome}");

            meuCachorro.EmitirSom();
            meuCachorro.Latir();
        }
    }

    public class Animal // Classe pai
    {
        public string Nome { get; set; } // Propriedade
        public virtual void EmitirSom() // Método
        {
            Console.WriteLine("Som genérico de animal");
        }
    }

    public class Cachorro : Animal // Classe derivada(filha)
    {
        public void Latir() // Método dessa classe
        {
            Console.WriteLine("Au, au");
        }

        public override void EmitirSom() // Método sobrescrevido da classe pai
        {
            Console.WriteLine("Latindo...");
        }
    }
}
