using WordPressDotNet.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WordPressDotNet.APILogic
{
    public class PostsController
    {
        private const string URL = "/wp-json/wp/v2/posts/";

        private string _baseUrl;
        private IEnumerable<Post> _posts;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url">Wordpress Site Url</param>
        public PostsController(string Url)
        {
            _baseUrl = Url;
        }

        /// <summary>
        /// Get all posts. Results are paged, default is 10 per page.
        /// </summary>
        /// <param name="page">Page number</param>
        /// <param name="perPage">Results you want per page</param>
        /// <returns></returns>
        public async Task<IEnumerable<Post>> GetPostsAsync(int page = 1, int perPage = 10)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + string.Format(URL + "?page={0}&per_page={1}", page, perPage));
            _posts = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Post>>(downloadedJson);
            return _posts;
        }

        /// <summary>
        /// Get a single post. 
        /// </summary>
        /// <param name="Id">WordPress Post Id</param>
        /// <returns></returns>
        public async Task<Post> GetPostAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL + Id.ToString());
            var post = Newtonsoft.Json.JsonConvert.DeserializeObject<Post>(downloadedJson);
            return post;
        }
    }
}
