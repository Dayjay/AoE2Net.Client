using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class LeaderboardPlayer
    {
        [JsonPropertyName("profile_id")]
        public int ProfileId { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("steam_id")]
        public string SteamId { get; set; }

        [JsonPropertyName("icon")]
        public object Icon { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clan")]
        public string Clan { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("previous_rating")]
        public int PreviousRating { get; set; }

        [JsonPropertyName("highest_rating")]
        public int HighestRating { get; set; }

        [JsonPropertyName("streak")]
        public int Streak { get; set; }

        [JsonPropertyName("lowest_streak")]
        public int LowestStreak { get; set; }

        [JsonPropertyName("highest_streak")]
        public int HighestStreak { get; set; }

        [JsonPropertyName("games")]
        public int Games { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("drops")]
        public int Drops { get; set; }

        [JsonPropertyName("last_match_time")]
        public int LastMatchTime { get; set; }
    }
}
