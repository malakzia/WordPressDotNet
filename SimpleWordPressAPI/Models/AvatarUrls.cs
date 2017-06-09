using Newtonsoft.Json;

namespace WordPressDotNet.Models
{
    public class AvatarUrls
    {
        [JsonProperty("24")]
        public string _24 { get; set; }

        [JsonProperty("48")]
        public string _48 { get; set; }

        [JsonProperty("96")]
        public string _96 { get; set; }
    }

}
