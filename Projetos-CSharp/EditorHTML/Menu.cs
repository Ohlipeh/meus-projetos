using System;

namespace EditorHtml
{
    public static class Menu //Define uma classe estática chamada "Menu".
    {
        public static void Show() //Método "Show()" exibe menu. Chamado para limpar a tela, mudar as cores e desenhar a borda com base nas dimensões.
        {
            Console.Clear(); //Limpa console
            Console.BackgroundColor = ConsoleColor.DarkRed; //Define cor do fundo.
            Console.ForegroundColor = ConsoleColor.Blue; //Define a cor da fonte.

            DrawScreen(50, 20); //Chama a função que desenha o quadrado no console. "50 é o num de colunas(largura)", "20 é o num de linhas(altura)".
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(int columns, int rows) //"columns" qnts caracteres terá de largura, "rows" qnts linhas terá de altura.
        {
            Console.Write("+"); //imprime um "+" no canto superior esquerdo.
            for (int i = 0; i < columns; i++)
                Console.Write("-"); //Desenha uma linha horizontal com "-" repetido.

            Console.Write("+\n"); //Fecha com outro "+" no canto superior direito.

            for (int line = 0; line < rows; line++)
            {
                Console.Write("|"); // Um "|" á esquerda.
                for (int i = 0; i < columns; i++)
                    Console.Write(" "); //Um espaço em branco no meio (vazio).

                Console.Write("|\n"); //Um "|" á direita.
            }

            //Mesmo padrão do topo: fecha o quadradocom outra linha de "-" e "+".
            Console.Write("+");
            for (int i = 0; i < columns; i++)
                Console.Write("-");

            Console.Write("+\n");

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Olá mundo!");

            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(5, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(5, 9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(5, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}