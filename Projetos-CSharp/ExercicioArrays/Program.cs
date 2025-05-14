using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DotnetLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            double[] notas = new double[5];
            double soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }

            double media = soma / notas.Length;

            Console.WriteLine("\nNotas digitadas:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }

            Console.WriteLine($"\nMédia do aluno: {media}");
            */

            /*
            int[] numeros = new int[5];

            //Pedir os números ao usuário 
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º numero: ");
                numeros[i] = int.Parse(Console.ReadLine()!);
            }

            int maior = numeros[0];
            int menor = numeros[0];
            int posMaior = 0;
            int posMenor = 0;

            //Comparar para encontrar maior e menor
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posMaior = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posMenor = i;
                }
            }
            Console.WriteLine($"\nMaior número: {maior} (posição {posMaior})");
            Console.WriteLine($"Menor número: {menor} (posição {posMenor})");
            */

            int[] numeros = new int[5];
            int soma = 0;

            for (int i = 0; i < numeros.Length; ++i)
            {
               Console.Write($"Digite o {i + 1}º número: ");
               numeros[i] = int.Parse(Console.ReadLine());
               soma += numeros[i];
            }

            double media = soma / (double)numeros.Length;

            Console.WriteLine("\nNúmeros digitados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine($"\nSoma: {soma}");
            Console.WriteLine($"\nMédia: {media}");
        }
    }
}
