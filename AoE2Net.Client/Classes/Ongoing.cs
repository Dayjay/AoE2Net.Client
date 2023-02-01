using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AoE2Net.Client.Classes
{
    public class Ongoing
    {
        [JsonPropertyName("data")]
        public List<OngoingMatch> OngoingMatches { get; set; }

        [JsonPropertyName("draw")]
        public int Draw { get; set; }

        [JsonPropertyName("recordsTotal")]
        public int RecordsTotal { get; set; }
    }
}
