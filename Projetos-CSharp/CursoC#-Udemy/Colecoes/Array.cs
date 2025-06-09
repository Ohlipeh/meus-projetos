using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "André";
            alunos[1] = "Felipe";
            alunos[2] = "Isensee";
            alunos[3] = "Leite";
            alunos[4] = "Ohlipeh";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9, .0, 9.0, 8.0, 7.0, 5.0 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            /*for(int i = 0; i < notas.Length; i++)
            {
                somatorio += notas[i];
            }*/

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'N', 'D', 'R', 'É' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}