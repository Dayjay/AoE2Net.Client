using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class LeaderboardPlayerRating
    {
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("num_wins")]
        public int NumWins { get; set; }

        [JsonPropertyName("num_losses")]
        public int NumLosses { get; set; }

        [JsonPropertyName("streak")]
        public int Streak { get; set; }

        [JsonPropertyName("drops")]
        public int Drops { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }
}
