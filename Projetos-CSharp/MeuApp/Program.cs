using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.Design;
using System.Reflection;

namespace MeuApp
{
  class Program
  {
    static List<string> nomes = new List<string>
    {
      "Ana Maria",
      "Mariana",
      "João",
      "Carlos",
      "ana clara",
      "Bruna"
    };

    static List<string> ultimosResultados = new List<string>();

    static void Main()
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("==== Menu ====");
      Console.WriteLine("1 - Buscar palavra (sensível a maiúsculas)");
      Console.WriteLine("2 - Buscar palavra (ignorar maiúsculas)");
      Console.WriteLine("3 - Salvar últimos resultados em arquivo");
      Console.WriteLine("4 - Adicionar novo nome");
      Console.WriteLine("5 - Remover nome");
      Console.WriteLine("6 - Listar todos os nomes");
      Console.WriteLine("0 - Sair");
      Console.Write("\nEscolha uma opção: ");
      string opcao = Console.ReadLine();

      switch (opcao)
      {
        case "1": Buscar(StringComparison.Ordinal); break;
        case "2": Buscar(StringComparison.Ordinal); break;
        case "3": SalvarResultados(); break;
        case "4": AdicionarNome(); break;
        case "5": RemoverNome(); break;
        case "6": ListarNomes(); break;
        case "0": Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Buscar(StringComparison tipoComparacao)
    {
      Console.Clear();
      Console.Write("Digite a palavra-chave: ");
      string palavra = Console.ReadLine();

      ultimosResultados.Clear();
      Console.WriteLine("\n[RESULTADOS ENCONTRADOS]");

      foreach (var nome in nomes)
      {
        if (nome.Contains(palavra, tipoComparacao))
        {
          Console.WriteLine($"- {nome}");
          ultimosResultados.Add(nome);
        }
      }

      if (ultimosResultados.Count == 0)
        Console.WriteLine("Nenhum nome encontrado.");

      Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
      Console.ReadKey();
      Menu();
    }

    static void SalvarResultados()
    {
      if (ultimosResultados.Count == 0)
      {
        Console.WriteLine("Nenhum resultado para salvar.");
        Console.ReadKey();
        Menu();
      }

      Console.Clear();
      Console.WriteLine("Digite o caminho e nome do arquivo (ex: resultado.txt):");
      string path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        foreach (var linha in ultimosResultados)
          file.WriteLine(linha);
      }

      Console.WriteLine($"Arquivo salvo com sucesso em: {path}");
      Console.ReadKey();
      Menu();
    }

    static void AdicionarNome()
    {
      Console.Clear();
      Console.Write("Digite o novo nome a adicionar: ");
      string novoNome = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(novoNome))
      {
        nomes.Add(novoNome);
        Console.WriteLine("Nome adicionado com sucesso!");
      }
      else
      {
        Console.WriteLine("Nome inválido.");
      }

      Console.ReadKey();
      Menu();
    }

    static void RemoverNome()
    {
      Console.Clear();
      Console.Write("Digite o nome a remover: ");
      string nomeRemover = Console.ReadLine();

      if (nomes.Remove(nomeRemover))
      {
        Console.WriteLine("Nome removido com sucesso!");
      }
      else
      {
        Console.WriteLine("Nome não encontrado.");
      }
      Console.ReadKey();
      Menu();
    }

    static void ListarNomes()
    {
      Console.Clear();
      Console.WriteLine("[LISTA DE NOMES]");
      foreach (var nome in nomes)
      {
        Console.WriteLine($"- {nome}");
      }

      Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
      Console.ReadKey();
      Menu();
    }

  }
}