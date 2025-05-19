using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ProjetoSinaleira
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tempoTotal = 300;
            const int tempoMin = 30;
            const int tempoMax = 120;

            List<string> nomesDasRuas = new List<string>();
            List<int> quantidadesDeCarros = new List<int>();

            Console.Write("Quantas ruas serão monitoradas? ");
            int quantidadeDeRuas = int.Parse(Console.ReadLine()!);

            // Entrada de dados
            for (int i = 0; i < quantidadeDeRuas; i++)
            {
                Console.Write($"Digite o nome da rua {i + 1}: ");
                nomesDasRuas.Add(Console.ReadLine()!);

                Console.Write($"Digite a quantidade de carros na rua {i + 1}: ");
                quantidadesDeCarros.Add(int.Parse(Console.ReadLine()!));
            }

            // Calculo da soma total de carros
            int somaTotalDeCarros = 0;
            foreach (int quantidade in quantidadesDeCarros)
            {
                somaTotalDeCarros += quantidade;
            }

            Console.WriteLine("\n--- Tempo ideal de abertura dos semáfaros ---");
            //Calculo do tempo proporcional por rua
            for (int i = 0; i < quantidadeDeRuas; i++)
            {
                double tempoCalculado = (double)tempoTotal * quantidadesDeCarros[i] / somaTotalDeCarros;

                //Aplicar limites mínimo e máximo
                int tempoFinal = (int)Math.Round(tempoCalculado);
                if (tempoFinal < tempoMin)
                    tempoFinal = tempoMin;
                else if (tempoFinal > tempoMax)
                    tempoFinal = tempoMax;

                Console.WriteLine($"{nomesDasRuas[i]}: {tempoFinal} segundos");
            }
        }
    }
}
