using System;

namespace SageOne.Entities
{
    public class CompanyEntityType : Entity<CompanyEntityType>
    {
        public int CountryId { get; set; }

        public string Name { get; set; }

        public bool CanIssueShares { get; set; }

        public string HoldingDescription { get; set; }

        public string HoldingUnit { get; set; }

        public string OwnershipDescription { get; set; }
    }
}