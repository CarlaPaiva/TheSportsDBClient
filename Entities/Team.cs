using Newtonsoft.Json;

namespace Entities
{
    public class Team
    {
        [JsonProperty("idTeam")]
        public int IdTeam { get; set; }

        [JsonProperty("idSoccerXML")]
        public int? IdSoccerXML { get; set; }

        [JsonProperty("idAPIfootball")]
        public int? IdAPIfootball { get; set; }

        [JsonProperty("intLoved")]
        public int? Loved { get; set; }

        [JsonProperty("strTeam")]
        public string Name { get; set; }

        [JsonProperty("strTeamShort")]
        public string TeamShort { get; set; }

        [JsonProperty("strAlternate")]
        public string Alternate { get; set; }

        [JsonProperty("intFormedYear")]
        public int? FormedYear { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("strLeague")]
        public string League { get; set; }

        [JsonProperty("idLeague")]
        public int IdLeague { get; set; }

        [JsonProperty("strLeague2")]
        public string League2 { get; set; }

        [JsonProperty("idLeague2")]
        public int? IdLeague2 { get; set; }

        [JsonProperty("strLeague3")]
        public string League3 { get; set; }

        [JsonProperty("idLeague3")]
        public int? IdLeague3 { get; set; }

        [JsonProperty("strDivision")]
        public string Division { get; set; }

        [JsonProperty("strManager")]
        public string Manager { get; set; }

        [JsonProperty("strStadium")]
        public string Stadium { get; set; }

        [JsonProperty("strKeywords")]
        public string Keywords { get; set; }

        [JsonProperty("strRSS")]
        public string RSS { get; set; }

        [JsonProperty("strStadiumThumb")]
        public string StadiumThumb { get; set; }

        [JsonProperty("strStadiumDescription")]
        public string StadiumDescription { get; set; }

        [JsonProperty("strStadiumLocation")]
        public string StadiumLocation { get; set; }

        [JsonProperty("intStadiumCapacity")]
        public int StadiumCapacity { get; set; }

        [JsonProperty("strWebsite")]
        public string Website { get; set; }

        [JsonProperty("strFacebook")]
        public string Facebook { get; set; }

        [JsonProperty("strTwitter")]
        public string Twitter { get; set; }

        [JsonProperty("strInstagram")]
        public string Instagram { get; set; }

        [JsonProperty("strDescriptionEN")]
        public string DescriptionEN { get; set; }

        [JsonProperty("strDescriptionPT")]
        public string DescriptionPT { get; set; }

        [JsonProperty("strGender")]
        public string Gender { get; set; }

        [JsonProperty("strCountry")]
        public string Country { get; set; }

        [JsonProperty("strTeamBadge")]
        public string TeamBadge { get; set; }

        [JsonProperty("strTeamJersey")]
        public string TeamJersey { get; set; }

        [JsonProperty("strTeamLogo")]
        public string TeamLogo { get; set; }

        [JsonProperty("strTeamFanart1")]
        public string TeamFanart1 { get; set; }

        [JsonProperty("strTeamFanart2")]
        public string TeamFanart2 { get; set; }

        [JsonProperty("strTeamFanart3")]
        public string TeamFanart3 { get; set; }

        [JsonProperty("strTeamFanart4")]
        public string TeamFanart4 { get; set; }

        [JsonProperty("strTeamBanner")]
        public string TeamBanner { get; set; }

        [JsonProperty("strYoutube")]
        public string Youtube { get; set; }

        [JsonProperty("strLocked")]
        public string Locked { get; set; }
    }
}
