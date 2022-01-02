using System;
using System.Diagnostics;

namespace DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple
{
    public class SingleResponsibilityPrinciple
    {
        public static void Executar()
        {
            var journal = new Journal();

            journal.AddEntry("I am a new journal");
            journal.AddEntry("I am the second journal");

            Console.WriteLine(journal);

            var fileName = @"Solid/SingleResponsibilityPrinciple/journal.txt";
            new JournalPersistence().SaveToFile(journal, fileName, true);

            Process.Start(fileName);
        }
    }
}