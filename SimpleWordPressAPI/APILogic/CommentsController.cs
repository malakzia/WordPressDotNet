using SimpleWordPressAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.APILogic
{
    public class CommentsController
    {

        private const string URL = "/wp-json/wp/v2/comments/";

        //enum WPJsonAPIVersion
        //{
        //    Old,
        //    New
        //}
        private string _baseUrl;
        private IEnumerable<Comment> _posts;
        public CommentsController(string Url/*, WPJsonAPIVersion api*/)
        {
            _baseUrl = Url;
        }
        /// <summary>
        /// Get all comments, against a post.
        /// </summary>
        /// <param name="postId">WordPress Post ID</param>
        /// <param name="page">Page number for results</param>
        /// <param name="perPage">Number of results per page</param>
        /// <returns></returns>
        public async Task<IEnumerable<Comment>> GetCommentsAsync(int postId, int page = 0, int perPage = 10)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + string.Format("/wp-json/wp/v2/comments?page={0}&per_page={1}&post={2}", page, perPage, postId));
            _posts = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Comment>>(downloadedJson);
            return _posts;
        }
        /// <summary>
        /// Get a single comment by ID.
        /// </summary>
        /// <param name="Id">Comment ID</param>
        /// <returns></returns>
        public async Task<Comment> GetCommentAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL + Id.ToString());
            var post = Newtonsoft.Json.JsonConvert.DeserializeObject<Comment>(downloadedJson);
            return post;
        }
    
}
}