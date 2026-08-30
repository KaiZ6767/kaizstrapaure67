using KaiZStrap.Models.APIs.RoValra;

namespace KaiZStrap.Models.APIs.RoValra
{
    public class RoValraTimeResponse
    {
        [JsonPropertyName("servers")]
        public List<RoValraServer>? Servers { get; set; } = null!;

        [JsonPropertyName("status")]
        public string Status = null!;
    }
}