using Newtonsoft.Json;

namespace Entities
{
    public class FormerTeam
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idPlayer")]
        public int IdPlayer { get; set; }

        [JsonProperty("idFormerTeam")]
        public int IdFormerTeam { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("strPlayer")]
        public string Player { get; set; }

        [JsonProperty("strFormerTeam")]
        public string FormerTeamName { get; set; }

        [JsonProperty("strMoveType")]
        public string MoveType { get; set; }

        [JsonProperty("strTeamBadge")]
        public string TeamBadge { get; set; }

        [JsonProperty("strJoined")]
        public string Joined { get; set; }

        [JsonProperty("strDeparted")]
        public string Departed { get; set; }
    }
}
