using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace serialization2
{
    [DataContract]
    internal class Product 
    {
        [DataMember] public string Name { get; set; }
        [DataMember] public decimal Price { get; set; }
        [DataMember] public string Description { get; set; }

        public Product(){}
        public Product(string name, decimal price, string description)
        {
            Name = name; Price = price; Description = description;
        }
        public override string ToString() => $"{this.Name}, {this.Price}, {this.Description}";

        
    }
}
