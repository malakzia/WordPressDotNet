namespace SimpleWordPressAPI.Models
{
    public class MediaDetails
    {

        public int width { get; set; }
        public int height { get; set; }
        public string file { get; set; }
        public Sizes sizes { get; set; }
        public ImageMeta image_meta { get; set; }
    }
}