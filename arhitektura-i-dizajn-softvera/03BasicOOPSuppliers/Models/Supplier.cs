using System;
using System.Collections.Generic;
using System.Linq;

namespace _03BasicOOPSuppliers.Models
{
    public class Supplier
    {
        public Guid Id { get; }
        public string Name { get; }
        public List<Product> Products { get; private set; }
        public Markup Markup { get; }

        public void ApplyPricePolicy()
        {
            Products = Products.Select(p => new Product(p, Markup)).ToList();
        }

        public Supplier(Guid id, string name, List<Product> products, Markup markup)
        {
            Id = id;
            Name = name;
            Products = products ?? new List<Product>();
            Markup = markup;
        }

        public Supplier(Guid id, string name, List<Product> products, byte markup)
            : this(id, name, products, new Markup(markup)) { }

        public Supplier(string name, List<Product> products, Markup markup)
            : this(Guid.NewGuid(), name, products, markup) { }

        public Supplier(string name, List<Product> products, byte markup)
            : this(name, products, new Markup(markup)) { }

        public override string ToString()
            => $"Supplier Name: {Name}{Environment.NewLine}List of products {string.Join(string.Empty, Products.Select(p => p.ToString()))}";
    }
}