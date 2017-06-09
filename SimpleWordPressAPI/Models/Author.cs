using System.Collections.Generic;

namespace WordPressDotNet.Models
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string slug { get; set; }
        public AvatarUrls avatar_urls { get; set; }
        public List<Meta> meta { get; set; }
        public AuthorLinks _links { get; set; }
    }
}