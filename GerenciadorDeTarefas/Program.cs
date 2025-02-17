using System;
using GerenciarTarefa;
using Layout;
using Tarefas;

class Program
{
    static void Main()
    {
        bool rodando = true;
        while (rodando)
        {
            Formatação.ImprimirCabecalho();
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Gerenciador.AdicionarTarefa();
                    break;
                case "2":
                    Gerenciador.ListarTarefa();
                    break;
                case "3":
                    Gerenciador.ConcluirTarefa();
                    break;
                case "4":
                    Gerenciador.RemoverTarefa();
                    break;
                case "5":
                    Formatação.Cor("Saindo...", ConsoleColor.Red);
                    rodando = false;
                    break;
                default:
                    Formatação.Cor("Opção inválida. Tente novamente.", ConsoleColor.Red);
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
