using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class LeaderboardMatchPlayer
    {
        [JsonPropertyName("profile_id")]
        public int ProfileId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clan")]
        public string Clan { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        [JsonPropertyName("slot_type")]
        public int SlotType { get; set; }

        [JsonPropertyName("rating")]
        public int? Rating { get; set; }

        [JsonPropertyName("rating_change")]
        public int? RatingChange { get; set; }

        [JsonPropertyName("color")]
        public int Color { get; set; }

        [JsonPropertyName("team")]
        public int Team { get; set; }

        [JsonPropertyName("civ")]
        public int Civ { get; set; }

        [JsonPropertyName("won")]
        public object Won { get; set; }
    }
}
