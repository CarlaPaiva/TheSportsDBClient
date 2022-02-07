using Entities;
using Newtonsoft.Json.Linq;
using System;

namespace TheSportsDB
{
    internal static class Mapper
    {
        public static Player MapPlayer(JObject item)
        {
            var newPlayer = new Player();

            newPlayer.IdPlayer = Convert.ToInt32(item["idPlayer"]);

            if (item["idTeam"].ToObject<object>() != null)
                newPlayer.IdTeam = Convert.ToInt32(item["idTeam"]);

            if (item["idTeam2"].ToObject<object>() != null)
                newPlayer.IdTeam2 = Convert.ToInt32(item["idTeam2"]);

            if (item["idTeamNational"].ToObject<object>() != null)
                newPlayer.IdTeamNational = Convert.ToInt32(item["idTeamNational"]);

            if (item["idSoccerXML"].ToObject<object>() != null)
                newPlayer.IdSoccerXML = Convert.ToInt32(item["idSoccerXML"]);

            if (item["intLoved"].ToObject<object>() != null)
                newPlayer.Loved = Convert.ToInt32(item["intLoved"]);

            if (item["idPlayerManager"].ToObject<object>() != null)
                newPlayer.IdPlayerManager = Convert.ToInt32(item["idPlayerManager"]);

            if (item["strNationality"].ToObject<object>() != null)
                newPlayer.Nationality = item["strNationality"].ToString();

            if (item["strSport"].ToObject<object>() != null)
                newPlayer.Sport = item["strSport"].ToString();

            if (item["intSoccerXMLTeamID"].ToObject<object>() != null)
                newPlayer.SoccerXMLTeamID = Convert.ToInt32(item["intSoccerXMLTeamID"]);

            //if (item["dateBorn"].ToObject<object>() != null)
              //  newPlayer.DateBorn = Convert.ToDateTime(item["dateBorn"]);

            if (item["strNumber"].ToObject<object>() != null)
                newPlayer.Number = item["strNumber"].ToString();

            if (item["strSigning"].ToObject<object>() != null)
                newPlayer.Signing = item["strSigning"].ToString();

            if (item["strWage"].ToObject<object>() != null)
                newPlayer.Wage = item["strWage"].ToString();

            if (item["strOutfitter"].ToObject<object>() != null)
                newPlayer.Outfitter = item["strOutfitter"].ToString();

            if (item["strKit"].ToObject<object>() != null)
                newPlayer.Outfitter = item["strKit"].ToString();

            if (item["strAgent"].ToObject<object>() != null)
                newPlayer.Agent = item["strAgent"].ToString();

            if (item["strBirthLocation"].ToObject<object>() != null)
                newPlayer.BirthLocation = item["strBirthLocation"].ToString();

            if (item["strDescriptionEN"].ToObject<object>() != null)
                newPlayer.DescriptionEN = item["strDescriptionEN"].ToString();

            if (item["strDescriptionPT"].ToObject<object>() != null)
                newPlayer.DescriptionPT = item["strDescriptionPT"].ToString();

            if (item["strGender"].ToObject<object>() != null)
                newPlayer.Gender = item["strGender"].ToString();

            if (item["strSide"].ToObject<object>() != null)
                newPlayer.Side = item["strSide"].ToString();

            if (item["strPosition"].ToObject<object>() != null)
                newPlayer.Side = item["strPosition"].ToString();

            if (item["strCollege"].ToObject<object>() != null)
                newPlayer.College = item["strCollege"].ToString();

            if (item["strFacebook"].ToObject<object>() != null)
                newPlayer.Facebook = item["strFacebook"].ToString();

            if (item["strTwitter"].ToObject<object>() != null)
                newPlayer.Twitter = item["strTwitter"].ToString();

            if (item["strInstagram"].ToObject<object>() != null)
                newPlayer.Instagram = item["strInstagram"].ToString();

            if (item["strYoutube"].ToObject<object>() != null)
                newPlayer.Youtube = item["strYoutube"].ToString();

            if (item["strHeight"].ToObject<object>() != null)
                newPlayer.Height = item["strHeight"].ToString();

            if (item["strWeight"].ToObject<object>() != null)
                newPlayer.Weight = item["strWeight"].ToString();

            if (item["strThumb"].ToObject<object>() != null)
                newPlayer.Thumb = item["strThumb"].ToString();

            if (item["strCutout"].ToObject<object>() != null)
                newPlayer.Cutout = item["strCutout"].ToString();

            if (item["strRender"].ToObject<object>() != null)
                newPlayer.Render = item["strRender"].ToString();

            if (item["strBanner"].ToObject<object>() != null)
                newPlayer.Banner = item["strBanner"].ToString();

            if (item["strFanart1"].ToObject<object>() != null)
                newPlayer.Fanart1 = item["strFanart1"].ToString();

            if (item["strFanart2"].ToObject<object>() != null)
                newPlayer.Fanart2 = item["strFanart2"].ToString();

            if (item["strFanart3"].ToObject<object>() != null)
                newPlayer.Fanart3 = item["strFanart3"].ToString();

            if (item["strFanart4"].ToObject<object>() != null)
                newPlayer.Fanart4 = item["strFanart4"].ToString();

            if (item["strCreativeCommons"].ToObject<object>() != null)
                newPlayer.CreativeCommons = item["strCreativeCommons"].ToString();

            if (item["strLocked"].ToObject<object>() != null)
                newPlayer.Locked = item["strLocked"].ToString();

            newPlayer.PlayerName = item["strPlayer"].ToString();

            newPlayer.Team = item["strTeam"].ToString();

            return newPlayer;
        }

        public static Team MapTeam(JObject item)
        {
            var newTeam = new Team();

            if (item["idTeam"].ToObject<object>() != null)
                newTeam.IdTeam = Convert.ToInt32(item["idTeam"]);

            if (item["idSoccerXML"].ToObject<object>() != null)
                newTeam.IdSoccerXML = Convert.ToInt32(item["idSoccerXML"]);

            if (item["idAPIfootball"].ToObject<object>() != null)
                newTeam.IdAPIfootball = Convert.ToInt32(item["idAPIfootball"]);

            if (item["intLoved"].ToObject<object>() != null)
                newTeam.Loved = Convert.ToInt32(item["intLoved"]);

            if (item["strTeam"].ToObject<object>() != null)
                newTeam.Name = item["strTeam"].ToString();

            if (item["strTeamShort"].ToObject<object>() != null)
                newTeam.TeamShort = item["strTeamShort"].ToString();

            if (item["strAlternate"].ToObject<object>() != null)
                newTeam.Alternate = item["strAlternate"].ToString();

            if (item["intFormedYear"].ToObject<object>() != null)
                newTeam.FormedYear = Convert.ToInt32(item["intFormedYear"]);

            if (item["strSport"].ToObject<object>() != null)
                newTeam.Sport = item["strSport"].ToString();

            if (item["strLeague"].ToObject<object>() != null)
                newTeam.League = item["strLeague"].ToString();

            if (item["idLeague"].ToObject<object>() != null)
                newTeam.IdLeague = Convert.ToInt32(item["idLeague"]);

            if (item["strLeague2"].ToObject<object>() != null)
                newTeam.League2 = item["strLeague2"].ToString();

            if (item["idLeague2"].ToObject<object>() != null)
                newTeam.IdLeague2 = Convert.ToInt32(item["idLeague2"]);

            if (item["strLeague3"].ToObject<object>() != null)
                newTeam.League3 = item["strLeague3"].ToString();

            if (item["idLeague3"].ToObject<object>() != null)
                newTeam.IdLeague3 = Convert.ToInt32(item["idLeague3"]);

            if (item["strDivision"].ToObject<object>() != null)
                newTeam.Division = item["strDivision"].ToString();

            if (item["strManager"].ToObject<object>() != null)
                newTeam.Manager = item["strManager"].ToString();

            if (item["strStadium"].ToObject<object>() != null)
                newTeam.Stadium = item["strStadium"].ToString();

            if (item["strKeywords"].ToObject<object>() != null)
                newTeam.Keywords = item["strKeywords"].ToString();

            if (item["strRSS"].ToObject<object>() != null)
                newTeam.RSS = item["strRSS"].ToString();

            if (item["strStadiumThumb"].ToObject<object>() != null)
                newTeam.StadiumThumb = item["strStadiumThumb"].ToString();

            if (item["strStadiumDescription"].ToObject<object>() != null)
                newTeam.StadiumDescription = item["strStadiumDescription"].ToString();

            if (item["strStadiumLocation"].ToObject<object>() != null)
                newTeam.StadiumLocation = item["strStadiumLocation"].ToString();

            if (item["intStadiumCapacity"].ToObject<object>() != null)
                newTeam.StadiumCapacity = Convert.ToInt32(item["intStadiumCapacity"]);

            if (item["strWebsite"].ToObject<object>() != null)
                newTeam.Website = item["strWebsite"].ToString();

            if (item["strFacebook"].ToObject<object>() != null)
                newTeam.Facebook = item["strFacebook"].ToString();

            if (item["strTwitter"].ToObject<object>() != null)
                newTeam.Twitter = item["strTwitter"].ToString();

            if (item["strInstagram"].ToObject<object>() != null)
                newTeam.Instagram = item["strInstagram"].ToString();

            if (item["strDescriptionEN"].ToObject<object>() != null)
                newTeam.DescriptionEN = item["strDescriptionEN"].ToString();

            if (item["strDescriptionPT"].ToObject<object>() != null)
                newTeam.DescriptionPT = item["strDescriptionPT"].ToString();

            if (item["strGender"].ToObject<object>() != null)
                newTeam.Gender = item["strGender"].ToString();

            if (item["strCountry"].ToObject<object>() != null)
                newTeam.Country = item["strCountry"].ToString();

            if (item["strTeamBadge"].ToObject<object>() != null)
                newTeam.TeamBadge = item["strTeamBadge"].ToString();

            if (item["strTeamJersey"].ToObject<object>() != null)
                newTeam.TeamJersey = item["strTeamJersey"].ToString();

            if (item["strTeamLogo"].ToObject<object>() != null)
                newTeam.TeamLogo = item["strTeamLogo"].ToString();

            if (item["strTeamFanart1"].ToObject<object>() != null)
                newTeam.TeamFanart1 = item["strTeamFanart1"].ToString();

            if (item["strTeamBanner"].ToObject<object>() != null)
                newTeam.TeamBanner = item["strTeamBanner"].ToString();

            if (item["strYoutube"].ToObject<object>() != null)
                newTeam.Youtube = item["strYoutube"].ToString();

            if (item["strLocked"].ToObject<object>() != null)
                newTeam.Locked = item["strLocked"].ToString();

            return newTeam;
        }

        public static Standing MapStanding(JObject item)
        {
            var newStanding = new Standing();

            if (item["idStanding"].ToObject<object>() != null)
                newStanding.IdStanding = Convert.ToInt32(item["idStanding"]);

            if (item["intRank"].ToObject<object>() != null)
                newStanding.Rank = Convert.ToInt32(item["intRank"]);

            if (item["idTeam"].ToObject<object>() != null)
                newStanding.IdTeam = Convert.ToInt32(item["idTeam"]);

            if (item["strTeam"].ToObject<object>() != null)
                newStanding.Team = item["strTeam"].ToString();

            if (item["strTeamBadge"].ToObject<object>() != null)
                newStanding.TeamBadge = item["strTeamBadge"].ToString();

            if (item["idLeague"].ToObject<object>() != null)
                newStanding.IdLeague = Convert.ToInt32(item["idLeague"]);

            if (item["strSeason"].ToObject<object>() != null)
                newStanding.Season = item["strSeason"].ToString();

            if (item["strForm"].ToObject<object>() != null)
                newStanding.Form = item["strForm"].ToString();

            if (item["strDescription"].ToObject<object>() != null)
                newStanding.Description = item["strDescription"].ToString();

            if (item["intPlayed"].ToObject<object>() != null)
                newStanding.Played = Convert.ToInt32(item["intPlayed"]);

            if (item["intWin"].ToObject<object>() != null)
                newStanding.Win = Convert.ToInt32(item["intWin"]);

            if (item["intLoss"].ToObject<object>() != null)
                newStanding.Loss = Convert.ToInt32(item["intLoss"]);

            if (item["intDraw"].ToObject<object>() != null)
                newStanding.Draw = Convert.ToInt32(item["intDraw"]);

            if (item["intGoalsFor"].ToObject<object>() != null)
                newStanding.GoalsFor = Convert.ToInt32(item["intGoalsFor"]);

            if (item["intGoalsAgainst"].ToObject<object>() != null)
                newStanding.GoalsAgainst = Convert.ToInt32(item["intGoalsAgainst"]);

            if (item["intGoalDifference"].ToObject<object>() != null)
                newStanding.GoalDifference = Convert.ToInt32(item["intGoalDifference"]);

            if (item["dateUpdated"].ToObject<object>() != null)
                newStanding.DateUpdated = Convert.ToDateTime(item["dateUpdated"]);

            return newStanding;
        }

        public static Sport MapSport(JObject item)
        {
            var newSport = new Sport();

            if (item["idSport"].ToObject<object>() != null)
                newSport.IdSport = Convert.ToInt32(item["idSport"]);

            if (item["strSport"].ToObject<object>() != null)
                newSport.Name = item["strSport"].ToString();

            if (item["strFormat"].ToObject<object>() != null)
                newSport.Format = item["strFormat"].ToString();

            if (item["strSportThumb"].ToObject<object>() != null)
                newSport.SportThumb = item["strSportThumb"].ToString();

            //if (item["strSportThumbGreen"].ToObject<object>() != null)
                //newSport.SportThumbGreen = item["strSportThumbGreen"].ToString();

            if (item["strSportDescription"].ToObject<object>() != null)
                newSport.SportDescription = item["strSportDescription"].ToString();


            return newSport;
        }

        public static Love MapLove(JObject item)
        {
            var newLove = new Love();

            if (item["idEdit"].ToObject<object>() != null)
                newLove.IdEdit = Convert.ToInt32(item["idEdit"]);

            if (item["strUsername"].ToObject<object>() != null)
                newLove.Username = item["strUsername"].ToString();

            if (item["strEditType"].ToObject<object>() != null)
                newLove.EditType = item["strEditType"].ToString();

            if (item["strReason"].ToObject<object>() != null)
                newLove.Reason = item["strReason"].ToString();

            if (item["date"].ToObject<object>() != null)
                newLove.Date = Convert.ToDateTime(item["date"]);

            if (item["idTeam"].ToObject<object>() != null)
                newLove.IdTeam = Convert.ToInt32(item["idTeam"]);

            if (item["idPlayer"].ToObject<object>() != null)
                newLove.IdPlayer = Convert.ToInt32(item["idPlayer"]);

            if (item["idLeague"].ToObject<object>() != null)
                newLove.IdLeague = Convert.ToInt32(item["idLeague"]);

            if (item["idEvent"].ToObject<object>() != null)
                newLove.IdEvent = Convert.ToInt32(item["idEvent"]);

            if (item["strTeam"].ToObject<object>() != null)
                newLove.Team = item["strTeam"].ToString();

            if (item["strPlayer"].ToObject<object>() != null)
                newLove.Player = item["strPlayer"].ToString();

            if (item["strLeague"].ToObject<object>() != null)
                newLove.League = item["strLeague"].ToString();

            if (item["strEvent"].ToObject<object>() != null)
                newLove.Event = item["strEvent"].ToString();

            if (item["strEventPoster"].ToObject<object>() != null)
                newLove.EventPoster = item["strEventPoster"].ToString();

            if (item["strPlayerThumb"].ToObject<object>() != null)
                newLove.PlayerThumb = item["strPlayerThumb"].ToString();

            if (item["strTeamBadge"].ToObject<object>() != null)
                newLove.TeamBadge = item["strTeamBadge"].ToString();

            return newLove;
        }

        public static League MapLeague(JObject item)
        {
            var newLeague = new League();

            if (item["idLeague"].ToObject<object>() != null)
                newLeague.IdLeague = Convert.ToInt32(item["idLeague"]);

            //if (item["idSoccerXML"].ToObject<object>() != null)
            //    newLeague.IdSoccerXML = Convert.ToInt32(item["idSoccerXML"]);

            //if (item["idAPIfootball"].ToObject<object>() != null)
            //    newLeague.IdAPIfootball = Convert.ToInt32(item["idAPIfootball"]);

            if (item["strSport"].ToObject<object>() != null)
                newLeague.Sport = item["strSport"].ToString();

            if (item["strLeague"].ToObject<object>() != null)
                newLeague.LeagueName = item["strLeague"].ToString();

            if (item["strLeagueAlternate"].ToObject<object>() != null)
                newLeague.LeagueAlternate = item["strLeagueAlternate"].ToString();

            //if (item["strDivision"].ToObject<object>() != null)
            //    newLeague.Division = item["strDivision"].ToString();

            /*if (item["idCup"].ToObject<object>() != null)
                newLeague.IdCup = Convert.ToInt32(item["idCup"]);

            if (item["strCurrentSeason"].ToObject<object>() != null)
                newLeague.CurrentSeason = item["strCurrentSeason"].ToString();

            if (item["intFormedYear"].ToObject<object>() != null)
                newLeague.FormedYear = Convert.ToInt32(item["intFormedYear"]);

            if (item["dateFirstEvent"].ToObject<object>() != null)
                newLeague.FirstEvent = Convert.ToDateTime(item["datedateFirstEvent"]);*/

            return newLeague;
        }
    }
}
