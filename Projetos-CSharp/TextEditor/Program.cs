using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace TextEditor
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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho abrir?");
            string path = Console.ReadLine();

            //Verificar se o arquivo existe
            if (!File.Exists(path))
            {
                Console.WriteLine("Arquivo não encontrado. Pressione qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Menu();
                return;
            }

            string text;

            using (var file = new StreamReader(path))
            {
                text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            //Contar linhas
            int linhas = text.Split('\n').Length;
            Console.WriteLine($"\nTotal de linhas: {linhas}");

            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            String text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            //contar palavras
            string[] palavras = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int quantidadePalavras = palavras.Length;

            Console.WriteLine($"\n\nQuantidade de palavras digitadas: {quantidadePalavras}");
            Console.WriteLine("Pressione qualquer tecla para continuar");

            //confirmar antes de salvar
            Console.WriteLine("\nDeseja salvar o texto? (s/n):");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
                Salvar(text);
            else
                Menu();
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine()!;

            Console.WriteLine("\nTem certeza que deseja salvar o arquivo? (s/n)");
            var confirmacao = Console.ReadLine()!.ToLower();

            if (confirmacao != "s")
            {

                Console.WriteLine("Operação cancelada. Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                Menu();
                return;
            }

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}
