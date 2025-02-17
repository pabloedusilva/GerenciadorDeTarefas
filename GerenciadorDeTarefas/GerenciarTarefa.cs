using System;
using System.Collections.Generic;
using Layout;
using Tarefas;

namespace GerenciarTarefa
{
    public static class Gerenciador
    {
        private static List<Tarefa> listaTarefas = new List<Tarefa>();
        private static int contadorId = 1;

        public static void AdicionarTarefa()
        {
            Formatação.Cor("Digite a descrição da tarefa:", ConsoleColor.White);
            string descricao = Console.ReadLine();
            listaTarefas.Add(new Tarefa(contadorId++, descricao));
            Formatação.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }

        public static void ListarTarefa()
        {
            Formatação.Cor("Lista de Tarefas:", ConsoleColor.White);
            if (listaTarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
            else
            {
                foreach (var tarefa in listaTarefas)
                {
                    tarefa.ExibirTarefa();
                }
            }
        }

        public static void ConcluirTarefa()
        {
            ListarTarefa();
            Formatação.Cor("Digite o ID da tarefa a concluir:", ConsoleColor.White);
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Tarefa tarefa = listaTarefas.Find(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefa.Concluida = true;
                    Formatação.Cor("Tarefa concluída!", ConsoleColor.Green);
                }
                else
                {
                    Formatação.Cor("Tarefa não encontrada.", ConsoleColor.Red);
                }
            }
        }

        public static void RemoverTarefa()
        {
            ListarTarefa();
            Formatação.Cor("Digite o ID da tarefa a remover:", ConsoleColor.White);
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Tarefa tarefa = listaTarefas.Find(t => t.Id == id);
                if (tarefa != null)
                {
                    listaTarefas.Remove(tarefa);
                    Formatação.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
                }
                else
                {
                    Formatação.Cor("Tarefa não encontrada.", ConsoleColor.Red);
                }
            }
        }
    }
}
