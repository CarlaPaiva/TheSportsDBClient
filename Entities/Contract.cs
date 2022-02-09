using Newtonsoft.Json;

namespace Entities
{
    public class Contract
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idPlayer")]
        public int IdPlayer { get; set; }

        [JsonProperty("idPlayer")]
        public int IdTeam { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("strPlayer")]
        public string Player { get; set; }

        [JsonProperty("strTeam")]
        public string Team { get; set; }

        [JsonProperty("strTeam")]
        public string TeamBadge { get; set; }

        [JsonProperty("strYearStart")]
        public string YearStart { get; set; }

        [JsonProperty("strYearEnd")]
        public string YearEnd { get; set; }

        [JsonProperty("strYearEnd")]
        public string Wage { get; set; }
    }
}
