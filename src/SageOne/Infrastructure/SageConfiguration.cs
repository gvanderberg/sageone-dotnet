using System.Reflection;
using Newtonsoft.Json;

namespace SageOne.Infrastructure
{
    public static class SageConfiguration
    {
        static SageConfiguration()
        {
            SageNetVersion = new AssemblyName(typeof(SageConfiguration).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        public static JsonSerializerSettings DefaultSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None
            };
        }

        public static string ApiVersion => "2.0.0";

        public static string SageNetVersion { get; }

        public static JsonSerializerSettings SerializerSettings { get; set; } = DefaultSerializerSettings();
    }
}