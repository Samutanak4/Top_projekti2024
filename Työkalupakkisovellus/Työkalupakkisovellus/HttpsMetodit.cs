using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Työkalupakkisovellus
{
    public class HttpsMetodit
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public HttpClientExample()
        {          
            _httpClient = new HttpClient();
            _baseUrl = "https://....????+.com"; // <-- API url 
        }

        
        public async Task<string> GetDataAsync() // GET
        {
            string apiUrl = _baseUrl + "/data"; // <- API endpoint
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }

        

        public async Task<string> CreateDataAsync(string data)//POST
        {
            string apiUrl = _baseUrl + "/data"; 

            HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, new StringContent(data));
            return await response.Content.ReadAsStringAsync();
        }

        
        public async Task<string> UpdateDataAsync(string id, string newData) //PUT
        {
            string apiUrl = _baseUrl + $"/data/{id}"; // Replace with your API endpoint
            HttpResponseMessage response = await _httpClient.PutAsync(apiUrl, new StringContent(newData));
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteDataAsync(string id)// DELETE
        {
            string apiUrl = _baseUrl + $"/data/{id}"; 
            HttpResponseMessage response = await _httpClient.DeleteAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
