using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           Pessoa pessoa = new Pessoa();
           pessoa.nome = "Marcos";
           pessoa.idade = 34;

           Console.WriteLine($"Nome: {pessoa.nome}\nIdade: {pessoa.idade}");
        }
    }

    class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
    }
}
