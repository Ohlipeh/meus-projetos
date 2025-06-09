using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        string nome = "Carlos";
        // int a = 10;
        public static void Executar()
        {
            DesafioAtributo pessoa = new DesafioAtributo();
            //  DesafioAtributo desafio = new DesafioAtributo();
                Console.WriteLine(pessoa.nome);
        }
    }
}
