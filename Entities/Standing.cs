using Newtonsoft.Json;
using System;

namespace Entities
{
    public class Standing
    {
        [JsonProperty("idStanding")]
        public int IdStanding { get; set; }

        [JsonProperty("intRank")]
        public int Rank { get; set; }

        [JsonProperty("idTeam")]
        public int IdTeam { get; set; }

        [JsonProperty("strTeam")]
        public string Team { get; set; }

        [JsonProperty("strTeamBadge")]
        public string TeamBadge { get; set; }

        [JsonProperty("idLeague")]
        public int IdLeague { get; set; }

        [JsonProperty("strLeague")]
        public string League { get; set; }

        [JsonProperty("strSeason")]
        public string Season { get; set; }

        [JsonProperty("strForm")]
        public string Form { get; set; }

        [JsonProperty("strDescription")]
        public string Description { get; set; }

        [JsonProperty("intPlayed")]
        public int Played { get; set; }

        [JsonProperty("intWin")]
        public int Win { get; set; }

        [JsonProperty("intLoss")]
        public int Loss { get; set; }

        [JsonProperty("intDraw")]
        public int Draw { get; set; }

        [JsonProperty("intGoalsFor")]
        public int GoalsFor { get; set; }

        [JsonProperty("intGoalsAgainst")]
        public int GoalsAgainst { get; set; }

        [JsonProperty("intGoalDifference")]
        public int GoalDifference { get; set; }

        [JsonProperty("dateUpdated")]
        public DateTime? DateUpdated { get; set; }
    }
}
