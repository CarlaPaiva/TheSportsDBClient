using System;

namespace Entities
{
    public class League
    {
        public int IdLeague { get; set; }
        public int? IdSoccerXML { get; set; }
        public int? IdAPIfootball { get; set; }
        public string Sport { get; set; }
        public string LeagueName { get; set; }
        public string LeagueAlternate { get; set; }
        public string Division { get; set; }
        public int IdCup { get; set; }
        public string CurrentSeason { get; set; }
        public int FormedYear { get; set; }
        public DateTime? FirstEvent { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string RSS { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionPT { get; set; }
        public string Fanart1 { get; set; }
        public string Fanart2 { get; set; }
        public string Fanart3 { get; set; }
        public string Fanart4 { get; set; }
        public string Banner { get; set; }
        public string Badge { get; set; }
        public string Logo { get; set; }
        public string Poster { get; set; }
        public string Trophy { get; set; }
        public string Naming { get; set; }
        public string Complete { get; set; }
        public string Locked { get; set; }
    }
}
