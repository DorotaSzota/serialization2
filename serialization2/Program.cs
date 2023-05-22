using System.Runtime.Serialization;
using System.Xml;

namespace serialization2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            { new Product("Apple", 2.5m, "A fine fruit."),
            new Product("Milk", 3.6m, "Skimmed milk"),
            new Product("Sweet Bun", 1.6m, "Soft and sweet")
            };

            var ds = new DataContractSerializer(typeof(List<Product>));
            using (var create = XmlWriter.Create("product.xml"))
            {
                ds.WriteObject(create, products);
            }

            List<Product> products2 = new List<Product>();
            using (Stream str = File.OpenRead("product.xml")) 
            products2 = (List<Product>)ds.ReadObject(str);

            foreach(Product product in products2)
            { Console.WriteLine(product.ToString()); }

        }
    }
}