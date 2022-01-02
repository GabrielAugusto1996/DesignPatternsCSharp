using System;
using System.Collections.Generic;

namespace DesignPatternsCSharp.Solid.SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new();
        private int count = 0;

        public int AddEntry(string entry)
        {
            entries.Add($"{++count}: {entry}");

            return count; //Memento
        }

        public void RemoveEntry(int position)
        {
            entries.RemoveAt(position);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}