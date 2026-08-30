namespace KaiZStrap.Models.APIs.Roblox
{
    public class OmniSearchGroup
    {
        [JsonPropertyName("contents")]
        public List<OmniSearchContent>? Contents { get; set; }
    }
}
