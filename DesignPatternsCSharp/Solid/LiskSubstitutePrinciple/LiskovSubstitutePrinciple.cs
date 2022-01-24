using System;

namespace DesignPatternsCSharp.Solid.LiskSubstitutePrinciple
{
    public class LiskovSubstitutePrinciple
    {
        public static void Executar()
        {
            Rectangle rectangle = new(3, 4);
            Console.WriteLine($"{rectangle} has area: {rectangle.GetArea()}");

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area: {square.GetArea()}");
        }
    }
}