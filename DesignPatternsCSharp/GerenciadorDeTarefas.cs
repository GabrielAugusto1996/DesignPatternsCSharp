using System;
using System.Collections.Generic;

namespace DesignPatternsCSharp
{
    public class GerenciadorDeTarefas
    {
        private static readonly Dictionary<int, Action> tasks = new();

        public static void AddTask(int number, Action task)
        {
            tasks.Add(number, task);
        }

        public static void ExecuteTask(int number)
        {
            try
            {
                tasks[number].Invoke();
            }
            catch (Exception _)
            {
                throw new ArgumentException($"A tarefa de numero: {number} nao existe");
            }
        }
    }
}
