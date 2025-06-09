using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto; //Colocando static no desconto viraria class e não instância!!!

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto()
            {

            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 5.5, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Boraacha",
                Preco = 3.5,
                // Desconto = 0.1 !!!
            };

            var produto3 = new Produto("Caderno", 22.5, 0.5);

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto3.CalcularDesconto());

            Produto.Desconto = 0.5; // <-- Nesse caso colocamos o mesmo desconto em todos os produtos. !!!
        }
    }
}