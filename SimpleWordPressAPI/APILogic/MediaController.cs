using WordPressDotNet.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WordPressDotNet.APILogic
{
    public class MediaController
    {
        private const string URL = "/wp-json/wp/v2/media/";

        private string _baseUrl;
        private IEnumerable<Media> _media;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url">Wordpress Site Url</param>
        public MediaController(string Url)
        {
            _baseUrl = Url;
        }

        /// <summary>
        /// Get all media. Results are paged, default is 10 per page.
        /// </summary>
        /// <param name="page">Page number</param>
        /// <param name="perPage">Results you want per page</param>
        /// <returns></returns>
        public async Task<IEnumerable<Media>> GetAllMediaAsync(int page = 1, int perPage = 10)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + string.Format(URL + "?page={0}&per_page={1}", page, perPage));
            _media = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Media>>(downloadedJson);
            return _media;
        }

        /// <summary>
        /// Get a single media. 
        /// </summary>
        /// <param name="Id">WordPress Media Id</param>
        /// <returns></returns>
        public async Task<Media> GetMediaAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL + Id.ToString());
            var media = Newtonsoft.Json.JsonConvert.DeserializeObject<Media>(downloadedJson);
            return media;
        }
    }
}