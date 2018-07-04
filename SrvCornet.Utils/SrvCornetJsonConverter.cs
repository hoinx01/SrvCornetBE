using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SrvCornet.Utils
{
    public class BuildinJsonSerializerSettings
    {
        public static readonly JsonSerializerSettings SNAKE = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };
        public static readonly JsonSerializerSettings CAMEL = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
    }
    public class SnakeJsonConverter
    {
        public static T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text, BuildinJsonSerializerSettings.SNAKE);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, BuildinJsonSerializerSettings.SNAKE);
        }
    }
    public class CamelJsonConverter
    {
        public static T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text, BuildinJsonSerializerSettings.CAMEL);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, BuildinJsonSerializerSettings.CAMEL);
        }
    }
}
