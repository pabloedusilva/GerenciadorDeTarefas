using System;

namespace Layout
{
    public static class Formatação
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()
        {
            string titulo = "GERENCIADOR DE TAREFAS";
            int largura = titulo.Length + 4;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetCursorPosition((Console.WindowWidth - largura) / 2, Console.CursorTop);
            Console.WriteLine("╔" + new string('═', largura) + "╗");

            Console.SetCursorPosition((Console.WindowWidth - largura) / 2, Console.CursorTop);
            Console.WriteLine("║  " + titulo + "  ║");

            Console.SetCursorPosition((Console.WindowWidth - largura) / 2, Console.CursorTop);
            Console.WriteLine("╚" + new string('═', largura) + "╝");

            Console.ResetColor();
        }
    }
}
