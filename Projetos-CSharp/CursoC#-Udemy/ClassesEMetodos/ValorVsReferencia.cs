using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string? Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente Dependent = new Dependente
            {
                Nome = "Linkin Park",
                Idade = 20
            };

            Dependente copiaDepe = Dependent;

            Console.WriteLine($"{Dependent.Nome} {copiaDepe.Nome}");
            Console.WriteLine($"{Dependent.Idade} {copiaDepe.Idade}");

            copiaDepe.Nome = "André Felipe Isensee Leite";
            Dependent.Idade = 31;

            Console.WriteLine($"{Dependent.Nome} {copiaDepe.Nome}");
            Console.WriteLine($"{Dependent.Idade} {copiaDepe.Idade}");
        }
    }
}