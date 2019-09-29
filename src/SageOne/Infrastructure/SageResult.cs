using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SageOne.Infrastructure
{
    public class SageResult<T>
    {
        public SageResult()
        {
            Results = new Collection<T>();
        }

        public int ReturnedResults { get; set; }

        public int TotalResults { get; set; }

        public ICollection<T> Results { get; set; }
    }
}