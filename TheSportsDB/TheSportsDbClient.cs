using Entities;
using Newtonsoft.Json;
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
            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchTeams, param);
            return JsonConvert.DeserializeObject<List<Team>>(result["team"]);
        }

        public List<Team> SearchTeamByShortCode(string shortCode)
        {
            var param = new Dictionary<string, string>
            {
                { "sname", shortCode }
            };

            var result = _requestBuilder.Request(Endpoints.SearchTeams, param);
            return JsonConvert.DeserializeObject<List<Team>>(result["team"]);
        }

        public List<Player> SearchPlayersFromTeam(string teamName)
        {
            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Team>>(result["player"]);
        }

        public List<Player> SearchPlayer(string playerName)
        {
            var param = new Dictionary<string, string>
            {
                { "p", playerName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Player>>(result["player"]);
        }

        public List<Player> SearchPlayer(string playerName, string teamName)
        {
            var param = new Dictionary<string, string>
            {
                { "p", playerName },
                { "t", teamName }
            };

            var result = _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Player>>(result["player"]);
        }

        public List<Sport> ListAllSports()
        {
            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.SearchAllSports, param);
            return JsonConvert.DeserializeObject<List<Sport>>(result["sports"]);
        }

        public List<League> ListAllLeagues()
        {
            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            return JsonConvert.DeserializeObject<List<League>>(result["leagues"]);
        }

        public List<Country> ListAllCountries()
        {
            var param = new Dictionary<string, string>();

            var result = _requestBuilder.Request(Endpoints.AllCountries, param);
            return JsonConvert.DeserializeObject<List<Country>>(result["country"]);
        }

        public List<League> ListAllLeaguesByCountry(string country)
        {
            var param = new Dictionary<string, string>
            {
                { "c", country }
            };

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            var players = result["league"];
            return JsonConvert.DeserializeObject<List<League>>(result["league"]);
        }

        public List<League> ListAllLeaguesByCountry(string country, string sport)
        {
            var param = new Dictionary<string, string>
            {
                { "c", country },
                { "s", sport }
            };

            var result = _requestBuilder.Request(Endpoints.AllLeagues, param);
            return JsonConvert.DeserializeObject<List<League>>(result["league"]);
        }
    }
}
