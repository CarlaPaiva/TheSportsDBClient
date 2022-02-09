using Newtonsoft.Json;

namespace Entities
{
    public class Country
    {
        [JsonProperty("name_en")]
        public string Name { get; set; }
    }
}
