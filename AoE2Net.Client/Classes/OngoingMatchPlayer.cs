using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class OngoingMatchPlayer
    {
        [JsonPropertyName("steamId")]
        public string SteamId { get; set; }

        [JsonPropertyName("profileId")]
        public int ProfileId { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        [JsonPropertyName("slotType")]
        public int SlotType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clan")]
        public string Clan { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("avatarfull")]
        public string Avatarfull { get; set; }

        [JsonPropertyName("avatarmedium")]
        public string Avatarmedium { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("color")]
        public int Color { get; set; }

        [JsonPropertyName("team")]
        public int Team { get; set; }

        [JsonPropertyName("civ")]
        public int Civ { get; set; }

        [JsonPropertyName("civName")]
        public string CivName { get; set; }
    }
}
