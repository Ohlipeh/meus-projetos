using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Good Evening {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Mãe", "Pai", "Irmãos", "Irmã", "Sobrinhos", "Sobrinhas");
        }
    }
}