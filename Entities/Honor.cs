using Newtonsoft.Json;

namespace Entities
{
    public class Honor
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idPlayer")]
        public int IdPlayer { get; set; }

        [JsonProperty("idTeam")]
        public int IdTeam { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("strPlayer")]
        public string Player { get; set; }

        [JsonProperty("strTeam")]
        public string Team { get; set; }

        [JsonProperty("strHonour")]
        public string Honour { get; set; }

        [JsonProperty("strSeason")]
        public string Season { get; set; }
    }
}
