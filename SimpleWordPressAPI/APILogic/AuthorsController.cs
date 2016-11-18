using SimpleWordPressAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWordPressAPI.APILogic
{
    public class AuthorsController
    {

        private string _baseUrl;

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
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + "/wp-json/wp/v2/users");
            var authors = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Author>>(downloadedJson);
            return authors;
        }
        /// <summary>
        /// Get a single WordPress Author
        /// </summary>
        /// <param name="Id">WordPress Author Id</param>
        /// <returns></returns>
        public async Task<Author> GetAuthorAsync(int Id)
        {
            var downloadedJson = await (new HttpClient()).GetStringAsync(_baseUrl + "/wp-json/wp/v2/users/" + Id.ToString());
            var author = Newtonsoft.Json.JsonConvert.DeserializeObject<Author>(downloadedJson);
            return author;
        }
    }
}
