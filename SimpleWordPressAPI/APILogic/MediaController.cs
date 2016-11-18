using SimpleWordPressAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.APILogic
{
    public class MediaController
    {
        private const string URL = "/wp-json/wp/v2/media/";

        //enum WPJsonAPIVersion
        //{
        //    Old,
        //    New
        //}

        private string _baseUrl;
        private IEnumerable<Media> _media;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url">Wordpress Url</param>
        public MediaController(string Url/*, WPJsonAPIVersion api*/)
        {

            _baseUrl = Url;
        }

        /// <summary>
        /// Get all media. Results are paged, default is 10 per page.
        /// </summary>
        /// <param name="page">Page number</param>
        /// <param name="perPage">Results you want per page</param>
        /// <returns></returns>
        public async Task<IEnumerable<Media>> GetPostsAsync(int page = 0, int perPage = 10)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + string.Format("/wp-json/wp/v2/media?page={0}&per_page={1}", page, perPage));
            _media = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Media>>(downloadedJson);
            return _media;
        }
        /// <summary>
        /// Get a single media. 
        /// </summary>
        /// <param name="Id">WordPress Media Id</param>
        /// <returns></returns>
        public async Task<Media> GetPostAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL + Id.ToString());
            var media = Newtonsoft.Json.JsonConvert.DeserializeObject<Media>(downloadedJson);
            return media;
        }
        
    }
}
