using Newtonsoft.Json;

namespace Entities
{
    public class Sport
    {
        [JsonProperty("idSport")]
        public int IdSport { get; set; }

        [JsonProperty("strSport")]
        public string Name { get; set; }

        [JsonProperty("strFormat")]
        public string Format { get; set; }

        [JsonProperty("strSportThumb")]
        public string SportThumb { get; set; }

        [JsonProperty("strSportThumbGreen")]
        public string SportThumbGreen { get; set; }

        [JsonProperty("strSportDescription")]
        public string SportDescription { get; set; }
    }
}
