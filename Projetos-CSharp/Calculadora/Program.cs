using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Calculator
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

            Console.WriteLine("Qual Operação matemática você deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Média");
            Console.WriteLine("6 - Raiz Quadrada");
            Console.WriteLine("7 - Potência");
            Console.WriteLine("8 - Potenciação");
            Console.WriteLine("9 - Porcentagem");
            Console.WriteLine("10 - Sair");

            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma opção: ");
            if (!short.TryParse(Console.ReadLine(), out short res))
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                return;
            }

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Media(); break;
                case 6: RaizQuadrada(); break;
                case 7: Potencia(); break;
                case 8: Potenciacao(); break;
                case 9: Porcentagem(); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v1))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("");

            Console.WriteLine("Segundo valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v2))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Terceiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v3))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;
            }

            decimal resultado = v1 + v2 + v3;
            Console.WriteLine($"O valor da soma é {resultado}");
            Console.ReadKey();
            DesejaContinuar();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v1))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Segundo valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v2))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Terceiro valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v3))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");

            decimal resultado = v1 - v2 - v3;
            Console.WriteLine($"O valor da subtração é {resultado}");
            Console.ReadKey();
            DesejaContinuar();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v1))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Segundo valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v2))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Terceiro valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v3))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");

            if (v2 == 0)
            {
                Console.WriteLine("Erro: não é possível dividir por zero!");
                Console.ReadKey();
                Menu();
                return;

            }

            decimal resultado = v1 / v2 / v3;
            Console.WriteLine($"O valor da divisão é {resultado}");
            Console.ReadKey();
            DesejaContinuar();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v1))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Segundo valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v2))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Terceiro valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v3))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");

            decimal resultado = v1 * v2 * v3;
            Console.WriteLine($"O valor da multiplicação é {resultado}");
            Console.ReadKey();
            DesejaContinuar();
        }

        static void RaizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("Digite o número para calcular a raiz quadrada:");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double valor))
            {
                double resultado = Math.Sqrt(valor);
                Console.WriteLine($"A raiz quadrada de {valor} é {resultado}");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            Console.ReadKey();
            DesejaContinuar();

        }

       static void Potencia()
       {
        Console.Clear();
        Console.WriteLine("Digite a base:");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente:");
        double expoente = double.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseNum, expoente);

        Console.WriteLine($"O resultado de {baseNum}^{expoente} é {resultado}");
        Console.ReadKey();
        DesejaContinuar();
       }
       
       static void Potenciacao()
       {
        Console.Clear();
        Console.WriteLine("Digite a base:");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente:");
        double expoente = double.Parse(Console.ReadLine());

        double reasultado = Math.Pow(baseNum, expoente);

        Console.WriteLine($"{baseNum} elevedo a {expoente} é {reasultado}");
        Console.ReadKey();
        DesejaContinuar();
       }

       static void Porcentagem()
       {
        Console.Clear();
        Console.WriteLine("Digite o valor total:");
        double total = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a porcentagem (%):");
        double porcentagem = double.Parse(Console.ReadLine());

        double resultado = (total * porcentagem) / 100;

        Console.WriteLine($"{porcentagem}% de {total} é {resultado}");
        Console.ReadKey();
        DesejaContinuar();
       }

        static void Media()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v1))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Segundo valor:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v2))
            {
                Console.WriteLine("valor inválido!");
                Console.ReadKey();
                Menu();
                return;

            }

            Console.WriteLine("Terceiro valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal v3))
            {
                Console.WriteLine("valor inválido");
                Console.ReadKey();
                Menu();
                return;
            }

            decimal resultado = (v1 + v2 + v3) / 2;
            Console.WriteLine($"A média dos valores é {resultado}");

            Console.ReadKey();
            DesejaContinuar();
        }

        static void DesejaContinuar()
        {
            Console.WriteLine("\nDeseja fazer outra operação? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
                Menu();

            else
            {
                Console.WriteLine("Encerrando o programa...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

