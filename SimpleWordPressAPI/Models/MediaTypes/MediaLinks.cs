using WordPressDotNet.Models.LinkTypes;

namespace WordPressDotNet.Models.MediaTypes
{
    public class MediaLinks : _Links
    {
        public About[] about { get; set; }
        public LinkTypes.Author[] author { get; set; }
        public Reply[] replies { get; set; }
    }
}
