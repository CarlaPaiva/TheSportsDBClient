using Entities;
using System.Collections.Generic;

namespace TheSportsDB
{
    public class TheSportsDbClient
    {
        private string ApiKey { get; set; }
        private readonly RequestBuilder _requestBuilder;
        public TheSportsDbClient()
        {
            this.ApiKey = "2";
            _requestBuilder = new RequestBuilder(this.ApiKey);
        }

        public TheSportsDbClient(string apiKey)
        {
            this.ApiKey = apiKey;
            _requestBuilder = new RequestBuilder(this.ApiKey);
        }

        public List<Team> SearchTeamByName(string teamName)
        {
            var listTeam = new List<Team>();

            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchTeams, param);
            var players = result["team"];

            foreach (var item in players)
            {
                listTeam.Add(Mapper.MapTeam(item));
            }

            return listTeam;
        }

        public List<Team> SearchTeamByShortCode(string shortCode)
        {
            var listTeam = new List<Team>();

            var param = new Dictionary<string, string>
            {
                { "sname", shortCode }
            };

            var result = _requestBuilder.Request(Endpoints.SearchTeams, param);
            var players = result["team"];

            foreach (var item in players)
            {
                listTeam.Add(Mapper.MapTeam(item));
            }

            return listTeam;
        }

        public List<Player> SearchPlayersFromTeam(string teamName)
        {
            var listPlayer = new List<Player>();

            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            var players = result["player"];

            foreach (var item in players)
            {
                listPlayer.Add(Mapper.MapPlayer(item));
            }

            return listPlayer;
        }

        public List<Player> SearchPlayer(string playerName)
        {
            var listPlayer = new List<Player>();

            var param = new Dictionary<string, string>
            {
                { "p", playerName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            var players = result["player"];

            foreach (var item in players)
            {
                listPlayer.Add(Mapper.MapPlayer(item));
            }

            return listPlayer;
        }

        public List<Player> SearchPlayer(string playerName, string teamName)
        {
            var listPlayer = new List<Player>();

            var param = new Dictionary<string, string>
            {
                { "p", playerName },
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            var players = result["player"];

            foreach (var item in players)
            {
                listPlayer.Add(Mapper.MapPlayer(item));
            }

            return listPlayer;
        }

        public List<Sport> ListAllSports()
        {
            var listSport = new List<Sport>();

            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.SearchAllSports, param);
            var players = result["sports"];

            if (players == null)
                return listSport;

            foreach (var item in players)
            {
                listSport.Add(Mapper.MapSport(item));
            }

            return listSport;
        }

        public List<League> ListAllLeagues()
        {
            var listLeague = new List<League>();

            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            var players = result["leagues"];

            foreach (var item in players)
            {
                listLeague.Add(Mapper.MapLeague(item));
            }

            return listLeague;
        }

        public List<Country> ListAllCountries()
        {
            var listCountry = new List<Country>();

            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.AllCountries, param);
            var players = result["country"];

            foreach (var item in players)
            {
                listCountry.Add(Mapper.MapCountry(item));
            }

            return listCountry;
        }

        public List<League> ListAllLeaguesByCountry(string country)
        {
            var listLeague = new List<League>();

            var param = new Dictionary<string, string>
            {
                { "c", country }
            };

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            var players = result["league"];

            foreach (var item in players)
            {
                listLeague.Add(Mapper.MapLeague(item));
            }

            return listLeague;
        }

        public List<League> ListAllLeaguesByCountry(string country, string sport)
        {
            var listLeague = new List<League>();

            var param = new Dictionary<string, string>
            {
                { "c", country },
                { "s", sport }
            };

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            var players = result["league"];

            foreach (var item in players)
            {
                listLeague.Add(Mapper.MapLeague(item));
            }

            return listLeague;
        }
    }
}
