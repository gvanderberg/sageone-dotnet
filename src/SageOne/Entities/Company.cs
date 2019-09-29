using System;

namespace SageOne.Entities
{
    public class Company : Entity<Company>
    {
        public int CompanyEntityTypeId { get; set; }

        public int CurrencyId { get; set; }

        public int CountryId { get; set; }

        public int HomeCurrencyId { get; set; }

        public string Name { get; set; }

        public string CurrencySymbol { get; set; }

        public int CurrencyDecimalDigits { get; set; }

        public int NumberDecimalDigits { get; set; }

        public string DecimalSeparator { get; set; }

        public int HoursDecimalDigits { get; set; }

        public int ItemCostPriceDecimalDigits { get; set; }

        public int ItemSellingPriceDecimalDigits { get; set; }
    }
}