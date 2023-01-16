using System.Text.Json.Serialization;

namespace AoE2Net.Client.Dtos
{
    public class StringIdPair
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("string")]
        public string String { get; set; }
    }
}
