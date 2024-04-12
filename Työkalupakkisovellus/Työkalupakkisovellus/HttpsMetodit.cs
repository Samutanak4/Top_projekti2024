using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Työkalupakkisovellus
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiClient(string baseUrl)
        {
            
            _httpClient = new HttpClient();
            _baseUrl = baseUrl; 
        }


        public async Task CreateUserAsync(string username, string password)
        {
            var requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("password", password)
            });

            string apiUrl = $"{_baseUrl}/users/{username}";
            HttpResponseMessage response = await _httpClient.PutAsync(apiUrl, requestContent);

            response.EnsureSuccessStatusCode();
        }
    }
}
