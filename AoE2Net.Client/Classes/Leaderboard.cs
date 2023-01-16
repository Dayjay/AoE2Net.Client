using System.Text.Json.Serialization;

namespace AoE2Net.Client.Classes
{
    public class Leaderboard
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("leaderboard_id")]
        public int LeaderboardId { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("leaderboard")]
        public List<LeaderboardPlayer> Players { get; set; }
    }
}
