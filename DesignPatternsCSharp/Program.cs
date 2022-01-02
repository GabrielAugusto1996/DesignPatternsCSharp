using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatternsCSharp.Solid.OpenClosedPrinciple;
using DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple;

namespace DesignPatternsCSharp
{
    public class Program
    {
        public static void Main(string[] _)
        {
            PrepareSolidTasks();

            Console.WriteLine("Informe o numero da tarefa");
            int opcao = int.Parse(Console.ReadLine());
            GerenciadorDeTarefas.ExecuteTask(opcao);
        }

        public static void PrepareSolidTasks()
        {
            Console.WriteLine("========== SOLID ==========");
            Console.WriteLine(GerenciadorDeTarefas.AddTask("Single Responsibility", SingleResponsibilityPrinciple.Executar));
            Console.WriteLine(GerenciadorDeTarefas.AddTask("Open-Closed", OpenClosedPrinciple.Executar));
            Console.WriteLine("==========       ==========");
        }
    }
}
