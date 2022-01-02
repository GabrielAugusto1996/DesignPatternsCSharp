using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple;

namespace DesignPatternsCSharp
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Program.PrepareSolidTasks();
            Console.WriteLine("Informe o numero da tarefa");
            int opcao = int.Parse(Console.ReadLine());

            GerenciadorDeTarefas.ExecuteTask(opcao);
        }

        public static void PrepareSolidTasks()
        {
            Console.WriteLine("========== SOLID ==========");
            Console.WriteLine("1 - Single Responsibility");
            GerenciadorDeTarefas.AddTask(1, SingleResponsibilityPrinciple.Executar);
            Console.WriteLine("==========       ==========");
        }
    }
}
