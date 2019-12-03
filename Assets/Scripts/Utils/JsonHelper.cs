using Newtonsoft.Json;

namespace Extend
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}

