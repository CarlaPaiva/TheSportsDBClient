using Newtonsoft.Json;
using System;

namespace Entities
{
    public class Player
    {
        [JsonProperty("idPlayer")]
        public int IdPlayer { get; set; }

        [JsonProperty("idTeam")]
        public int IdTeam { get; set; }

        [JsonProperty("idTeam2")]
        public int? IdTeam2 { get; set; }

        [JsonProperty("idTeamNational")]
        public int? IdTeamNational { get; set; }

        [JsonProperty("idSoccerXML")]
        public int? IdSoccerXML { get; set; }

        [JsonProperty("idPlayerManager")]
        public int? IdPlayerManager { get; set; }

        [JsonProperty("strNationality")]
        public string Nationality { get; set; }

        [JsonProperty("strPlayer")]
        public string PlayerName { get; set; }

        [JsonProperty("strTeam")]
        public string Team { get; set; }

        [JsonProperty("strTeam2")]
        public string Team2 { get; set; }

        [JsonProperty("strSport")]
        public string Sport { get; set; }

        [JsonProperty("intSoccerXMLTeamID")]
        public int? SoccerXMLTeamID { get; set; }

        [JsonProperty("dateBorn")]
        public DateTime DateBorn { get; set; }

        [JsonProperty("strNumber")]
        public string Number { get; set; }

        [JsonProperty("dateSign")]
        public DateTime DateSign { get; set; }

        [JsonProperty("strSigning")]
        public string Signing { get; set; }

        [JsonProperty("strWage")]
        public string Wage { get; set; }

        [JsonProperty("strOutfitter")]
        public string Outfitter { get; set; }

        [JsonProperty("strKit")]
        public string Kit { get; set; }

        [JsonProperty("strAgent")]
        public string Agent { get; set; }

        [JsonProperty("strBirthLocation")]
        public string BirthLocation { get; set; }

        [JsonProperty("strDescriptionEN")]
        public string DescriptionEN { get; set; }

        [JsonProperty("strDescriptionDE")]
        public string DescriptionDE { get; set; }

        [JsonProperty("strDescriptionPT")]
        public string DescriptionPT { get; set; }

        [JsonProperty("strGender")]
        public string Gender { get; set; }

        [JsonProperty("strSide")]
        public string Side { get; set; }

        [JsonProperty("strPosition")]
        public string Position { get; set; }

        [JsonProperty("strCollege")]
        public string College { get; set; }

        [JsonProperty("strFacebook")]
        public string Facebook { get; set; }

        [JsonProperty("strTwitter")]
        public string Twitter { get; set; }

        [JsonProperty("strInstagram")]
        public string Instagram { get; set; }

        [JsonProperty("strYoutube")]
        public string Youtube { get; set; }

        [JsonProperty("strHeight")]
        public string Height { get; set; }

        [JsonProperty("strWeight")]
        public string Weight { get; set; }

        [JsonProperty("intLoved")]
        public int Loved { get; set; }

        [JsonProperty("strThumb")]
        public string Thumb { get; set; }

        [JsonProperty("strCutout")]
        public string Cutout { get; set; }

        [JsonProperty("strRender")]
        public string Render { get; set; }

        [JsonProperty("strBanner")]
        public string Banner { get; set; }

        [JsonProperty("strFanart1")]
        public string Fanart1 { get; set; }

        [JsonProperty("strFanart2")]
        public string Fanart2 { get; set; }

        [JsonProperty("strFanart3")]
        public string Fanart3 { get; set; }

        [JsonProperty("strFanart4")]
        public string Fanart4 { get; set; }

        [JsonProperty("strCreativeCommons")]
        public string CreativeCommons { get; set; }

        [JsonProperty("strLocked")]
        public string Locked { get; set; }
    }
}
