using System.Collections.Generic;

namespace DesignPatternsCSharp.Solid.OpenClosedPrinciple
{
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(Size size, IEnumerable<Product> products)
        {
            foreach(var product in products)
            {
                if (product.Size == size)
                {
                    yield return product;
                }
            }
        }
    }
}