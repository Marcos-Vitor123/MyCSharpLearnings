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

// get e set: São usados para acessar e modificar as propriedades de uma classe
// get: Obtém o valor atual de uma propriedade
// set: Define um novo valor para essa propriedade
// Propriedades definidas como públicas: Elas podem ser acessadas e modificadas por qualquer parte do código
// get e set: São úteis quando precisa controlar o acesso a propriedades
