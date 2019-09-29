using System;

namespace SageOne.Entities
{
    public class Account : Entity<Account>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int AccountType { get; set; }

        public bool Active { get; set; }

        public decimal Balance { get; set; }

        public int? DefaultTaxTypeId { get; set; }

        public bool HasActivity { get; set; }

        public bool IsTaxLocked { get; set; }

        public int? ReportingGroupId { get; set; }

        public bool UnallocatedAccount { get; set; }
    }
}