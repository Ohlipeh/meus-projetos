using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("5 = Ver histórico de contagem");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            int minutos = 0;
            int segundos = 0;

            if (data == "0")
                Environment.Exit(0);

            if (data == "5")
            {
                verHistorico();
                return;
            }
            if (data.Contains("m"))
            {
                int indexM = data.IndexOf("m");
                minutos = int.Parse(data.Substring(0, indexM));

                if (data.Contains("s"))
                {
                    int indexS = data.IndexOf("s");
                    segundos = int.Parse(data.Substring(indexM + 1, indexS - indexM - 1));
                }
            }
            else if (data.Contains("s"))
            {
                int indexS = data.IndexOf("s");
                segundos = int.Parse(data.Substring(0, indexS));
            }
            int totalSegundos = (minutos * 60) + segundos;

            if (totalSegundos == 0)
            Environment.Exit(0);

            PreStart(totalSegundos);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(900);
            Console.WriteLine("Set...");
            Thread.Sleep(900);
            Console.WriteLine("Go...");
            Thread.Sleep(900);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(900);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            historico.Add($"Você contou {time} segundo(s) em {DateTime.Now:T}");
            Thread.Sleep(2500);
            Menu();
        }

        static List<string> historico = new List<string>();

        static void verHistorico()
        {
            Console.Clear();
            Console.WriteLine("Histórico de contagens:\n");

            if (historico.Count == 0)
                Console.WriteLine("Nenhum tempo contado ainda.");
            else
                foreach (var item in historico)
                    Console.WriteLine(item);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }
    }
}

