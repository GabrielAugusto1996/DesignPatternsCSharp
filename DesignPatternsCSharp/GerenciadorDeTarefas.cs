using System;
using System.Collections.Generic;

namespace DesignPatternsCSharp
{
    public class GerenciadorDeTarefas
    {
        private static readonly Dictionary<int, Action> tasks = new();
        private static int count = 1;

        public static string AddTask(string title, Action task)
        {
            tasks.Add(count, task);

            var titleWithCount = $"{count} - {title}";

            ++count;
            return titleWithCount;
        }

        public static void ExecuteTask(int number)
        {
            if (number >= count)
            {
                tasks[count - 1].Invoke();
            }
            else
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
}
