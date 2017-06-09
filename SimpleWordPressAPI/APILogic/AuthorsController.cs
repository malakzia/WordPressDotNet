using WordPressDotNet.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WordPressDotNet.APILogic
{
    public class AuthorsController
    {
        private const string URL = "/wp-json/wp/v2/users/";

        private string _baseUrl;
        private IEnumerable<Author> _authors;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url">Wordpress Site url</param>
        public AuthorsController(string Url)
        {
            _baseUrl = Url;
        }

        /// <summary>
        /// Get all WordPress Authors
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL);
            _authors = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Author>>(downloadedJson);
            return _authors;
        }

        /// <summary>
        /// Get a single WordPress Author
        /// </summary>
        /// <param name="Id">WordPress Author Id</param>
        /// <returns></returns>
        public async Task<Author> GetAuthorAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + URL + Id.ToString());
            var author = Newtonsoft.Json.JsonConvert.DeserializeObject<Author>(downloadedJson);
            return author;
        }
    }
}
