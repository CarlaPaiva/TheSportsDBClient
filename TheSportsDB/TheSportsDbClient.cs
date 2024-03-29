﻿using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheSportsDB
{
    public class TheSportsDbClient
    {
        private readonly RequestBuilder _requestBuilder;
        public TheSportsDbClient()
        {
            _requestBuilder = new RequestBuilder(new TheSportsDBClientConfiguration());
        }

        public TheSportsDbClient(TheSportsDBClientConfiguration configuration)
        {
            _requestBuilder = new RequestBuilder(configuration);
        }


        /// <summary>
        /// Search for team by name.
        /// </summary>
        /// <param name="teamName">Team name</param>
        /// <returns></returns>
        public async Task<List<Team>> SearchTeamByNameAsync(string teamName)
        {
            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchTeams, param);

            if (result == null)
                return null;

            return JsonConvert.DeserializeObject<List<Team>>(result["team"].ToString());
        }

        /// <summary>
        /// Search for team short code.
        /// </summary>
        /// <param name="shortCode">Team short code.</param>
        /// <returns></returns>
        public async Task<List<Team>> SearchTeamByShortCodeAsync(string shortCode)
        {
            var param = new Dictionary<string, string>
            {
                { "sname", shortCode }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchTeams, param);
            return JsonConvert.DeserializeObject<List<Team>>(result["team"].ToString());
        }

        /// <summary>
        /// Search for all players from team
        /// </summary>
        /// <param name="teamName">Team name</param>
        /// <returns></returns>
        public async Task<List<Player>> SearchPlayersFromTeamAsync(string teamName)
        {
            var param = new Dictionary<string, string>
            {
                { "t", teamName }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Player>>(result["player"].ToString());
        }

        /// <summary>
        /// Search for player by name.
        /// </summary>
        /// <param name="playerName">Name of the player.</param>
        /// <returns></returns>
        public async Task<List<Player>> SearchPlayerAsync(string playerName)
        {
            var param = new Dictionary<string, string>
            {
                { "p", playerName }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Player>>(result["player"].ToString());
        }

        /// <summary>
        /// Search for players by name and team name.
        /// </summary>
        /// <param name="playerName">Players name</param>
        /// <param name="teamName">teams name</param>
        /// <returns></returns>
        public async Task<List<Player>> SearchPlayerAsync(string playerName, string teamName)
        {
            var param = new Dictionary<string, string>
            {
                { "p", playerName },
                { "t", teamName }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchPlayers, param);
            return JsonConvert.DeserializeObject<List<Player>>(result["player"].ToString());
        }

        /// <summary>
        /// Search for event by event name
        /// </summary>
        /// <param name="eventName">Event name</param>
        /// <returns></returns>
        public async Task<List<Player>> SearchEventAsync(string eventName)
        {
            var param = new Dictionary<string, string>
            {
                { "e", eventName }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchEvent, param);
            return JsonConvert.DeserializeObject<List<Player>>(result.First.ToString());
        }

        public async Task<List<Player>> SearchEventAsync(string eventName, string season)
        {
            var param = new Dictionary<string, string>
            {
                { "e", eventName },
                { "s", season }
            };

            var result = await _requestBuilder.Request(Endpoints.SearchEvent, param);
            return JsonConvert.DeserializeObject<List<Player>>(result.First.ToString());
        }

        /// <summary>
        /// List all sports available at TheSportsDb
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sport>> ListAllSportsAsync()
        {
            var param = new Dictionary<string, string>();

            var result = await _requestBuilder.Request(Endpoints.SearchAllSports, param);
            return JsonConvert.DeserializeObject<List<Sport>>(result["sports"].ToString());
        }

        /// <summary>
        /// List all leagues available at TheSportsDb 
        /// </summary>
        /// <returns></returns>
        public async Task<List<League>> ListAllLeaguesAsync()
        {
            var param = new Dictionary<string, string>();

            var result = await _requestBuilder.Request(Endpoints.AllLeagues, param);
            return JsonConvert.DeserializeObject<List<League>>(result["leagues"].ToString());
        }

        /// <summary>
        /// List all countries available at TheSportsDb
        /// </summary>
        /// <returns></returns>
        public async Task<List<Country>> ListAllCountries()
        {
            var param = new Dictionary<string, string>();

            var result = await _requestBuilder.Request(Endpoints.AllCountries, param);
            return JsonConvert.DeserializeObject<List<Country>>(result["countries"].ToString());
        }

        /// <summary>
        /// List all leagues available at TheSportsDb
        /// </summary>
        /// <param name="country">Country name</param>
        /// <returns></returns>
        public async Task<List<League>> ListAllLeaguesByCountryAsync(string country)
        {
            var param = new Dictionary<string, string>
            {
                { "c", country }
            };

            var result = await _requestBuilder.Request(Endpoints.AllLeagues, param);
            return JsonConvert.DeserializeObject<List<League>>(result["leagues"].ToString());
        }

        /// <summary>
        /// List all leagues available at TheSportsDb
        /// </summary>
        /// <param name="country">Country name</param>
        /// <param name="sport">Sport name</param>
        /// <returns></returns>
        public async Task<List<League>> ListAllLeaguesByCountryAsync(string country, string sport)
        {
            var param = new Dictionary<string, string>
            {
                { "c", country },
                { "s", sport }
            };

            var result = await _requestBuilder.Request(Endpoints.AllLeagues, param);
            return JsonConvert.DeserializeObject<List<League>>(result["league"].ToString());
        }
    }
}
