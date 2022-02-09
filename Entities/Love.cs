using Newtonsoft.Json;
using System;

namespace Entities
{
    public class Love
    {
        [JsonProperty("idEdit")]
        public int IdEdit { get; set; }

        [JsonProperty("strUsername")]
        public string Username { get; set; }

        [JsonProperty("strEditType")]
        public string EditType { get; set; }

        [JsonProperty("strReason")]
        public string Reason { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("idTeam")]
        public int? IdTeam { get; set; }

        [JsonProperty("idPlayer")]
        public int? IdPlayer { get; set; }

        [JsonProperty("idLeague")]
        public int? IdLeague { get; set; }

        [JsonProperty("idEvent")]
        public int? IdEvent { get; set; }

        [JsonProperty("strTeam")]
        public string Team { get; set; }

        [JsonProperty("strPlayer")]
        public string Player { get; set; }

        [JsonProperty("strLeague")]
        public string League { get; set; }

        [JsonProperty("strEvent")]
        public string Event { get; set; }

        [JsonProperty("strEventPoster")]
        public string EventPoster { get; set; }

        [JsonProperty("strPlayerThumb")]
        public string PlayerThumb { get; set; }

        [JsonProperty("strTeamBadge")]
        public string TeamBadge { get; set; }
    }
}
