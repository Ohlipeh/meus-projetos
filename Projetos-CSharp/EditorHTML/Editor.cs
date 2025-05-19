using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EditorHtml
{
  public static class Editor
  {

    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("-----------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
         file.Append(Console.ReadLine());
         file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("---------------");
      Console.Write("\nDeseja salvar o arquivo? (s/n): ");
      var opcao = Console.ReadLine()!.ToLower();

      if (opcao == "s")
      SalvarArquivo(file.ToString());
      Viewer.Show(file.ToString());
    }

    public static void SalvarArquivo(string text)
    {
      Console.Clear();
      Console.WriteLine("Informe o caminho para salvar o arquivo: ");
      var path = Console.ReadLine()!;

      Console.WriteLine("\nDseja realmente salvar o arquivo? (s/n)");
      var confirmacao = Console.ReadLine()!.ToLower();

      if (confirmacao != "s")
      {
        Console.WriteLine("Operação cancelada. Pressiona qualquer tecla para voltar ao menu");
        Console.ReadKey();
        return;
      }

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"Arquivo {path} salvo com sucesso!");
      Console.ReadLine();
    }

  }
}