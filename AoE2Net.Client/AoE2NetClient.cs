using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.Json;
using AoE2Net.Client.Classes;
using AoE2Net.Client.Dtos;
using AoE2Net.Client.Enums;
using AoE2Net.Client.Exceptions;
using AoE2Net.Client.Extensions;

namespace AoE2Net.Client
{
    public class AoE2NetClient
    {
        private readonly HttpClient httpClient;
        private readonly Language language;

        /// <summary>
        /// AoE2.net API Client
        /// </summary>
        /// <param name="name">The name of your application.</param>
        /// <param name="language">The response language, defaults to English</param>
        public AoE2NetClient(string name, Language language = Language.English)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://aoe2.net")
            };
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", name);

            this.language = language;
        }

        /// <summary>
        /// Request a list of strings used by the API.
        /// </summary>
        /// <returns>A collection of Id and String pairs.</returns>
        /// <exception cref="AoE2NetClientException"></exception>
        public async Task<StringsResponse> GetStringsAsync()
        {
            var url = $"/api/strings?game=aoe2de&language={language.ToName()}";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<StringsResponse>(responseString);
            }
            else
            {
                throw new AoE2NetClientException("AoE2.Net API did not return a valid response.");
            }
        }

        /// <summary>
        /// Request the current leaderboards.
        /// </summary>
        /// <param name="leaderboardType">The leaderboard type.</param>
        /// <param name="start">Starting rank, ignored if any optional parameter is provided.</param>
        /// <param name="count">The number of entries to return, must be 10000 or less.</param>
        /// <param name="search">Search by name.</param>
        /// <param name="steamId">Search by Steam-ID</param>
        /// <param name="profileId">Search by Profile-ID</param>
        /// <returns></returns>
        /// <exception cref="AoE2NetClientException"></exception>
        public async Task<Leaderboard> GetLeaderboardAsync(LeaderboardType leaderboardType, int start, int count, string? search = null, int? steamId = null, int? profileId = null)
        {
            if (count > 10000)
            {
                throw new AoE2NetClientException("Can't return more than 10000 entries.");
            }

            var url = $"/api/leaderboard?game=aoe2de&leaderboard_id={(int)leaderboardType}&start={start}&count={count}";

            if (search != null)
            {
                url = string.Format("{0}&search={1}", url, search);
            }
            if (steamId != null)
            {
                url = string.Format("{0}&steam_id={1}", url, steamId);
            }
            if (profileId != null)
            {
                url = string.Format("{0}&profile_id={1}", url, profileId);
            }

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Leaderboard>(responseString);
            }
            else
            {
                throw new AoE2NetClientException("AoE2.Net API did not return a valid response.");
            }
        }

        /// <summary>
        /// Request the rating history for a player.
        /// </summary>
        /// <param name="leaderboardType">The leaderboard type.</param>
        /// <param name="start">Starting match, 0 ist the most recent match.</param>
        /// <param name="count">The number of entries to return, must be 10000 or less.</param>
        /// <param name="steamId">Search by Steam-ID</param>
        /// <param name="profileId">Search by Profile-ID</param>
        /// <returns></returns>
        /// <exception cref="AoE2NetClientException"></exception>
        public async Task<List<LeaderboardPlayerRating>> GetRatingHistoryAsync(LeaderboardType leaderboardType, int start, int count, int? steamId = null, int? profileId = null)
        {
            if (count > 10000)
            {
                throw new AoE2NetClientException("Can't return more than 10000 entries.");
            }

            if (steamId == null && profileId == null)
            {
                throw new AoE2NetClientException("A SteamID or ProfileID is required.");
            }

            var url = $"/api/player/ratinghistory?game=aoe2de&leaderboard_id={(int)leaderboardType}&start={start}&count={count}";

            if (steamId != null)
            {
                url = string.Format("{0}&steam_id={1}", url, steamId);
            }
            if (profileId != null)
            {
                url = string.Format("{0}&profile_id={1}", url, profileId);
            }

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<LeaderboardPlayerRating>>(responseString);
            }
            else
            {
                throw new AoE2NetClientException("AoE2.Net API did not return a valid response.");
            }
        }

        /// <summary>
        /// Request the match history for a player.
        /// </summary>
        /// <param name="count">The number of entries to return, must be 1000 or less.</param>
        /// <param name="steamId">Search by Steam-ID</param>
        /// <param name="profileId">Search by Profile-ID</param>
        /// <param name="start">Starting match, 0 ist the most recent match.</param>
        /// <returns></returns>
        /// <exception cref="AoE2NetClientException"></exception>
        public async Task<List<LeaderboardMatch>> GetPlayerMatchHistoryAsync(int count, int? steamId = null, int? profileId = null, int? start = null)
        {
            if (count > 1000)
            {
                throw new AoE2NetClientException("Can't return more than 1000 entries.");
            }

            if (steamId == null && profileId == null)
            {
                throw new AoE2NetClientException("A SteamID or ProfileID is required.");
            }

            var url = $"/api/player/matches?game=aoe2de&count={count}";

            if (steamId != null)
            {
                url = string.Format("{0}&steam_id={1}", url, steamId);
            }
            if (profileId != null)
            {
                url = string.Format("{0}&profile_id={1}", url, profileId);
            }
            if (start != null)
            {
                url = string.Format("{0}&count={1}", url, start);
            }

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<LeaderboardMatch>>(responseString);
            }
            else
            {
                throw new AoE2NetClientException("AoE2.Net API did not return a valid response.");
            }
        }

        /// <summary>
        /// Request the match history for multiple players.
        /// </summary>
        /// <param name="count">The number of entries to return, must be 1000 or less.</param>
        /// <param name="steamIds">Search by Steam-IDs</param>
        /// <param name="profileIds">Search by Profile-IDs</param>
        /// <param name="start">Starting match, 0 ist the most recent match.</param>
        /// <returns></returns>
        /// <exception cref="AoE2NetClientException"></exception>
        public async Task<List<LeaderboardMatch>> GetPlayersMatchHistoryAsync(int count, IEnumerable<string>? steamIds = null, IEnumerable<string>? profileIds = null, int? start = null)
        {
            if (count > 1000)
            {
                throw new AoE2NetClientException("Can't return more than 1000 entries.");
            }

            if (steamIds == null && profileIds == null)
            {
                throw new AoE2NetClientException("A SteamID or ProfileID is required.");
            }

            var url = $"/api/player/matches?game=aoe2de&count={count}";

            if (steamIds != null)
            {
                url = string.Format("{0}&steam_ids={1}", url, string.Join(",", steamIds));
            }
            if (profileIds != null)
            {
                url = string.Format("{0}&profile_ids={1}", url, string.Join(",", profileIds));
            }
            if (start != null)
            {
                url = string.Format("{0}&count={1}", url, start);
            }
            Console.Write(url);
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<LeaderboardMatch>>(responseString);
            }
            else
            {
                throw new AoE2NetClientException("AoE2.Net API did not return a valid response.");
            }
        }
    }
}