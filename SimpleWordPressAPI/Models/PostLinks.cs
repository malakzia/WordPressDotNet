using Newtonsoft.Json;
using WordPressDotNet.Models.LinkTypes;

namespace WordPressDotNet.Models
{
    public class PostLinks : _Links
    {
        public About[] about { get; set; }
        public LinkTypes.Author[] author { get; set; }
        public Reply[] replies { get; set; }

        [JsonProperty("version-history")]
        public VersionHistory[] versionHistory { get; set; }

        [JsonProperty("wp:attachment")]
        public WpAttachment[] wpAttachment { get; set; }

        [JsonProperty("wp:term")]
        public WpTerm[] wpTerm { get; set; }

        public Cury[] curies { get; set; }
    }
}
