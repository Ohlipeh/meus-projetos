using System;
using System.Collections.Generic;

namespace AlertaAlagamento
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            
            // Entrada de dados
            Console.Write("Quantas regiões deseja cadastrar? ");
            int quantidadeRegioes = int.Parse(Console.ReadLine());

            // Lista para armazenar os dados das regiões
            List<Regiao> regioes = new List<Regiao>();

            // Coleta dos dados
            for (int i = 0; i < quantidadeRegioes; i++)
            {
                Console.WriteLine($"\nRegião {i + 1}:");

                Console.Write("Nome da região: ");
                string nome = Console.ReadLine();

                Console.Write("Nível de risco (chuva em mm): ");
                int risco = int.Parse(Console.ReadLine());

                //Verificação do alerta
                bool alerta = risco > 50;

                // Armazenamento de dados da região
                regioes.Add(new Regiao { Nome = nome, Risco = risco, Alerta = alerta });
            }

            // Mostrar resultado
            Console.WriteLine("\nResultado do alerta:");
            foreach (Regiao regiao in regioes)
            {
                Console.WriteLine($"Região: {regiao.Nome} | Alerta: {regiao.Alerta}");
            }
        }
    }

    internal class Regiao
    {
        public string Nome { get; set; }
        public int Risco { get; set; }
        public bool Alerta { get; set; }
    }
}
