using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class JsonOperation
    {
        public static string JsonSerialize<T>(IList<T> liste)
        {
            return JsonConvert.SerializeObject(liste);
        }
        public static List<T> JsonDeserialize<T>(string seralized)
        {
            return JsonConvert.DeserializeObject<List<T>>(seralized);

        }
    }
}
