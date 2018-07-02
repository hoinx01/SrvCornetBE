using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Iken.Core
{
    //Dùng newtonjson với naming strategy là snake_case
    public class SrvCornetJsonConverter
    {
        public static T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text, SNAKE);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, SNAKE);
        }

        private static JsonSerializerSettings SNAKE = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };
    }
}
