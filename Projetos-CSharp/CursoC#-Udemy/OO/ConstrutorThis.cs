using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {
            var Sheeva = new Cachorro("Sheeva");
            var Bob = new Cachorro("Bob", 30.0);

            Console.WriteLine(Sheeva);
            Console.WriteLine(Bob);
        }
    }
}