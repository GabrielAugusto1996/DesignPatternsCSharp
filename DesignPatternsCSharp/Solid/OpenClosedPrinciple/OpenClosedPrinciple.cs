using System;
using System.Collections.Generic;

namespace DesignPatternsCSharp.Solid.OpenClosedPrinciple
{
    public class OpenClosedPrinciple
    {
        public static void Executar()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var iphone = new Product("Iphone", Color.Black, Size.Small);
            var tablet = new Product("Tablet", Color.Blue, Size.Large);

            Product[] products = { apple, iphone, tablet };

            Console.WriteLine("Produtos nao filtrados");
            foreach (var product in products)
                Console.WriteLine(product.Name);

            var productsFiltered = ProductFilter.FilterBySize(Size.Small, products);

            Console.WriteLine("Produtos filtrados");
            foreach (var product in products)
                Console.WriteLine(product.Name);
        }
    }
}