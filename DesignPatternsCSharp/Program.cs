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

            Console.WriteLine("========== SOLID ==========");
            Console.WriteLine("1 - Single Responsibility:");
            GerenciadorDeTarefas.AddTarefa(1, SingleResponsibilityPrinciple.Executar);
            Console.WriteLine("==========       ==========");
            
            Console.WriteLine("Informe o numero da tarefa");
            int opcao = int.Parse(Console.ReadLine());

            GerenciadorDeTarefas.ExecutarTarefa(opcao);
        }
    }
}
