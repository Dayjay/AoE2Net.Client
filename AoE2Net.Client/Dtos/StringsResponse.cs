using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AoE2Net.Client.Dtos
{
    public class StringsResponse
    {
        [JsonPropertyName("age")]
        public List<StringIdPair> Ages { get; set; }

        [JsonPropertyName("civ")]
        public List<StringIdPair> Civs { get; set; }

        [JsonPropertyName("game_type")]
        public List<StringIdPair> GameTypes { get; set; }

        [JsonPropertyName("leaderboard")]
        public List<StringIdPair> Leaderboards { get; set; }

        [JsonPropertyName("map_size")]
        public List<StringIdPair> MapSizes { get; set; }

        [JsonPropertyName("map_type")]
        public List<StringIdPair> MapTypes { get; set; }

        [JsonPropertyName("rating_type")]
        public List<StringIdPair> RatingTypes { get; set; }

        [JsonPropertyName("resources")]
        public List<StringIdPair> Resources { get; set; }

        [JsonPropertyName("speed")]
        public List<StringIdPair> Speeds { get; set; }

        [JsonPropertyName("victory")]
        public List<StringIdPair> Victories { get; set; }

        [JsonPropertyName("visibility")]
        public List<StringIdPair> Visibilities { get; set; }
    }
}
