using WordPressDotNet.APILogic;

namespace WordPressDotNet
{
    /// <summary>
    /// Connect to WordPress site with REST API. Easily access Posts, Media, Authors and Comments. 
    /// 
    /// Requires WP-REST-API V2 plugin installed on your WordPress site (Below V4.7). For information see http://v2.wp-api.org/    
    /// </summary>
    public class WordPressConnector
    {
        /// <summary>
        /// Connect to WordPress site with REST API. Easily access Posts, Media, Authors and Comments. 
        /// 
        /// Requires WP-REST-API V2 plugin installed on your WordPress site (Below V4.7). For information see http://v2.wp-api.org/
        /// </summary>
        /// <param name="Url">Url of your WordPress site. For example http://ZiaNasir.com/</param>
        public WordPressConnector(string Url)
        {
            Posts = new PostsController(Url);
            Media = new MediaController(Url);
            Authors = new AuthorsController(Url);
            Comments = new CommentsController(Url);
        }

        public PostsController Posts { get; }
        public MediaController Media { get; }
        public AuthorsController Authors { get; }
        public CommentsController Comments { get; }
    }
}
