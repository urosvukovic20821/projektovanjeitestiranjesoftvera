using System;

namespace _03BasicOOPSuppliers.Models
{
    public class Markup
    {
        public byte Percent { get; }
        public decimal Value => (decimal)Percent / 100;

        public Markup(byte percent)
        {
            if (percent > 100) throw new ArgumentOutOfRangeException(nameof(percent));
            Percent = percent;
        }

        public override string ToString() => $"Markup percent: {Percent}";
    }
}