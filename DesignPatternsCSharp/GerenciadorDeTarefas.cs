using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple;

namespace DesignPatternsCSharp
{
    public class GerenciadorDeTarefas
    {
        private static readonly Dictionary<int, Action> tarefas = new();

        public static void AddTarefa(int numero, Action tarefa)
        {
            tarefas.Add(numero, tarefa);
        }

        public static void ExecutarTarefa(int numero)
        {
            try
            {
                tarefas[numero].Invoke();
            }
            catch (Exception _)
            {
                throw new ArgumentException($"A tarefa de numero: {numero} nao existe");
            }
        }
    }
}
