using System;

namespace SageOne.Entities
{
    public class TaxType : Entity<TaxType>
    {
        public string Name { get; set; }

        public decimal Percentage { get; set; }

        public bool HasActivity { get; set; }

        public bool IsDefault { get; set; }

        public bool IsManualTax { get; set; }
    }
}