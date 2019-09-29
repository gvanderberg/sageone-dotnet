using System;
using Newtonsoft.Json;
using SageOne.Common;
using SageOne.Infrastructure;

namespace SageOne.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class Entity : IEntity
    {
        public static T FromJson<T>(string value) where T : IEntity
        {
            return JsonConvert.DeserializeObject<T>(value, SageConfiguration.SerializerSettings);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, SageConfiguration.SerializerSettings);
        }

        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }

    public abstract class Entity<T> : Entity where T : Entity<T>
    { }
}