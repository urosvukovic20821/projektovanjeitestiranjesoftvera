namespace _03BasicOOPSuppliers.Models
{
    public class Currency
    {
        public string Code { get; }

        public string Name { get; }

        public string Symbol { get; }

        public static Currency Default => new("EUR", "Euro", "€");

        public Currency(string code, string name, string symbol)
        {
            Code = code;
            Name = name;
            Symbol = symbol;
        }

        public override string ToString() => Symbol;
    }
}