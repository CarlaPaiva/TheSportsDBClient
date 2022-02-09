using Newtonsoft.Json;
using System;

namespace Entities
{
    public class League
    {
        [JsonProperty("idLeague")]
        public int IdLeague { get; set; }

        [JsonProperty("idSoccerXML")]
        public int? IdSoccerXML { get; set; }

        [JsonProperty("idAPIfootball")]
        public int? IdAPIfootball { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("strLeague")]
        public string LeagueName { get; set; }

        [JsonProperty("strLeagueAlternate")]
        public string LeagueAlternate { get; set; }

        [JsonProperty("strDivision")]
        public string Division { get; set; }

        [JsonProperty("idCup")]
        public int? IdCup { get; set; }

        [JsonProperty("strCurrentSeason")]
        public string CurrentSeason { get; set; }

        [JsonProperty("intFormedYear")]
        public int FormedYear { get; set; }

        [JsonProperty("dateFirstEvent")]
        public DateTime? FirstEvent { get; set; }

        [JsonProperty("strGender")]
        public string Gender { get; set; }

        [JsonProperty("strCountry")]
        public string Country { get; set; }

        [JsonProperty("strWebsite")]
        public string Website { get; set; }

        [JsonProperty("strFacebook")]
        public string Facebook { get; set; }

        [JsonProperty("strTwitter")]
        public string Twitter { get; set; }

        [JsonProperty("strYoutube")]
        public string Youtube { get; set; }

        [JsonProperty("strRSS")]
        public string RSS { get; set; }

        [JsonProperty("strDescriptionEN")]
        public string DescriptionEN { get; set; }

        [JsonProperty("strDescriptionPT")]
        public string DescriptionPT { get; set; }

        [JsonProperty("strFanart1")]
        public string Fanart1 { get; set; }

        [JsonProperty("strFanart2")]
        public string Fanart2 { get; set; }

        [JsonProperty("strFanart3")]
        public string Fanart3 { get; set; }

        [JsonProperty("strFanart4")]
        public string Fanart4 { get; set; }

        [JsonProperty("strBanner")]
        public string Banner { get; set; }

        [JsonProperty("strBadge")]
        public string Badge { get; set; }

        [JsonProperty("strLogo")]
        public string Logo { get; set; }

        [JsonProperty("strPoster")]
        public string Poster { get; set; }

        [JsonProperty("strTrophy")]
        public string Trophy { get; set; }

        [JsonProperty("strNaming")]
        public string Naming { get; set; }

        [JsonProperty("strComplete")]
        public string Complete { get; set; }

        [JsonProperty("strLocked")]
        public string Locked { get; set; }
    }
}
