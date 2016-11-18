using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.Models
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string slug { get; set; }
        public Avatar_Urls avatar_urls { get; set; }
        public Meta meta { get; set; }
        public _Links _links { get; set; }
        public bool embeddable { get; set; }
        public string href { get; set; }
    }

}
