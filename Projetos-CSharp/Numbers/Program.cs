using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /* Formatando moedas, siglas mais usadas N, P e C.
             decimal valor = 10300.25m;
             Console.WriteLine(valor.ToString("N",CultureInfo.CreateSpecificCulture("es-ES")));
            */

            /*
             decimal valor = 10300.25m;
             Console.WriteLine(Math.Round(valor)); //Arredonda o valor.
             Console.WriteLine(Math.Ceiling(valor)); //Arredonda valor pra cima.
             Console.WriteLine(Math.Floor(valor)); //Arredonda pra baixo.
            */

            /*
             Exercicio 1
             Console.Write("Digite um valor decimal: ");
             decimal valor = decimal.Parse(Console.ReadLine());

             int opcao;
             do
             {
                Console.Clear();
                Console.WriteLine("Escolha a cultura para formatar o valor:");
                Console.WriteLine("1 - Brasil");
                Console.WriteLine("2 - EUA");
                Console.WriteLine("3 - Japão");
                Console.WriteLine("4 - Alemanha");
                Console.WriteLine("0 - Sair");

                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        MostrarValorFormatado(valor, "pt-BR");
                        break;
                    case 2:
                        MostrarValorFormatado(valor, "en-US");
                        break;
                    case 3:
                        MostrarValorFormatado(valor, "ja-JP");
                        break;
                    case 4:
                        MostrarValorFormatado(valor, "de-DE");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
             } while (opcao != 0);
             }

             static void MostrarValorFormatado(decimal valor, string cultura)
             {
             var formato = valor.ToString("C", CultureInfo.CreateSpecificCulture(cultura));
             Console.WriteLine($"Valor formatado ({cultura}): {formato}");
           */

            //Exercicio 2
            Console.Write("Digite um número decimal: ");
            decimal numero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha o tipo de arredondamento:");
            Console.WriteLine("1 - Arredondar normalmente (Math.ROund)");
            Console.WriteLine("2 - Arrendodar para cima (MAth.Ceiling)");
            Console.WriteLine("3 - Arredondar para baixo (Math.Floor)");

            Console.Write("\nDigite a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            decimal resultado = 0;

            if (opcao == 1)
            {
                resultado = Math.Round(numero);
            }
            else if (opcao == 2)
            {
                resultado = (decimal)Math.Ceiling((double)numero);
            }
            else if (opcao == 3)
            {
                resultado = (decimal)Math.Floor((double)numero);
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                return;
            }

            Console.WriteLine($"\nResultado: {resultado}");

        }
    }
}
