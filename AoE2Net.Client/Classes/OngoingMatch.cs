using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class OngoingMatch
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("matchId")]
        public int MatchId { get; set; }

        [JsonPropertyName("appId")]
        public int AppId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("numPlayers")]
        public int NumPlayers { get; set; }

        [JsonPropertyName("numSlots")]
        public int NumSlots { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("full")]
        public bool Full { get; set; }

        [JsonPropertyName("isLobby")]
        public bool IsLobby { get; set; }

        [JsonPropertyName("averageRating")]
        public int AverageRating { get; set; }

        [JsonPropertyName("gameType")]
        public string GameType { get; set; }

        [JsonPropertyName("gameTypeId")]
        public int GameTypeId { get; set; }

        [JsonPropertyName("leaderboard")]
        public string Leaderboard { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("mapSize")]
        public string MapSize { get; set; }

        [JsonPropertyName("ranked")]
        public bool Ranked { get; set; }

        [JsonPropertyName("ratingTypeId")]
        public int RatingTypeId { get; set; }

        [JsonPropertyName("resources")]
        public string Resources { get; set; }

        [JsonPropertyName("server")]
        public string Server { get; set; }

        [JsonPropertyName("startingAge")]
        public string StartingAge { get; set; }

        [JsonPropertyName("numSpectators")]
        public int NumSpectators { get; set; }

        [JsonPropertyName("matchHtml")]
        public string MatchHtml { get; set; }

        [JsonPropertyName("opened")]
        public int Opened { get; set; }

        [JsonPropertyName("started")]
        public int Started { get; set; }

        [JsonPropertyName("players")]
        public List<OngoingMatchPlayer> Players { get; set; }
    }
}
