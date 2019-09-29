using System;

namespace SageOne.Common
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime Created { get; set; }

        DateTime Modified { get; set; }
    }
}