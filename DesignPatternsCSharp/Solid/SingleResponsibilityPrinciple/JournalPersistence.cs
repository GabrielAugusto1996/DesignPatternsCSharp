using System.IO;

namespace DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple
{
    public class JournalPersistence
    {
        public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, journal.ToString());
            }
        }
    }
}