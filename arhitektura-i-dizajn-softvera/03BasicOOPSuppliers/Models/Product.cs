using System;

namespace _03BasicOOPSuppliers.Models
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; }
        public uint Quantity { get; }
        public bool Available => Quantity > 0;
        public Price InitialPrice { get; }
        public Price SellingPrice { get; set; }

        public Product(Guid id, string name, uint quantity, Price initialPrice)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            InitialPrice = initialPrice;
            SellingPrice = Price.DefaultPrice;
        }

        public Product(Guid id, string name, uint quantity, decimal initialPrice, Currency currency)
            : this(id, name, quantity, new Price(initialPrice, currency)) { }

        public Product(string name, uint quantity, Price initialPrice)
            : this(Guid.NewGuid(), name, quantity, initialPrice) { }

        public Product(string name, uint quantity, decimal initialPrice, Currency currency)
            : this(Guid.NewGuid(), name, quantity, initialPrice, currency) { }

        public Product(string name, uint quantity, decimal initialPrice)
            : this(Guid.NewGuid(), name, quantity, initialPrice, Currency.Default) { }

        public Product(Product p, Markup markup)
        {
            Id = p.Id;
            Name = p.Name;
            Quantity = p.Quantity;
            InitialPrice = p.InitialPrice;
            SellingPrice = p.InitialPrice + p.InitialPrice * markup;
        }

        public override string ToString()
            => $"Product Name: {Name}{Environment.NewLine}Quantity: {Quantity}{Environment.NewLine}Initial Price: {InitialPrice}{Environment.NewLine}Selling price {SellingPrice}";
    }
}