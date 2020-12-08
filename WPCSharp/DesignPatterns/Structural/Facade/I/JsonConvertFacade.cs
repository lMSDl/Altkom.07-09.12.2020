using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.I
{
    public static class JsonConvertFacade
    {
        private static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings()
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            Formatting = Formatting.Indented
        };

        public static string Serialize<T>(T @object)
        {
            return JsonConvert.SerializeObject(@object, Settings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
