using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.Models
{
    public class Comment
    {
        public int id { get; set; }
        public int post { get; set; }
        public int parent { get; set; }
        public int author { get; set; }
        public string author_name { get; set; }
        public string author_url { get; set; }
        public string date { get; set; }
        public string date_gmt { get; set; }
        public Content content { get; set; }
        public string link { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public AuthorAvatarUrls author_avatar_urls { get; set; }
        public Meta meta { get; set; }
        public _Links _links { get; set; }
    }
}
