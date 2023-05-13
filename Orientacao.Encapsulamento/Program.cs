using System;

namespace Orientacao.Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 25;

            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
        }

        class Pessoa
        {
            private string nome;
            private int idade;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public int Idade
            {
                get { return idade; }
                set { idade = value; }
            }
        }
    }
}
