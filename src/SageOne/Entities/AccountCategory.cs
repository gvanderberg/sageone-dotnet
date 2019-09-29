using System;

namespace SageOne.Entities
{
    public class AccountCategory : Entity<AccountCategory>
    {
        public string Comment { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }
    }
}