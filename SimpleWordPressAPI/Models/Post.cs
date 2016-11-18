using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.Models
{
    public class Post
    {
        public int id { get; set; }
        public string date { get; set; }
        public string date_gmt { get; set; }
        public Guid guid { get; set; }
        public string modified { get; set; }
        public string modified_gmt { get; set; }
        public string slug { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public Title title { get; set; }
        /// <summary>
        /// HTML content of the post
        /// </summary>
        public Content content { get; set; }
        public Excerpt excerpt { get; set; }
        public int author { get; set; }
        public int featured_media { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public bool sticky { get; set; }
        public string format { get; set; }
        public Meta meta { get; set; }
        public List<int> categories { get; set; }
        public List<object> tags { get; set; }
        public _Links _links { get; set; }
    }
}
