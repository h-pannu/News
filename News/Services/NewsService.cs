using News.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace News.Services
{
    public class NewsService
    {
        private HttpClient httpClient;
        private List<NewsToday> newsToday = new();
        public NewsService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<NewsToday>> GetNewsTodays()
        {
            var url = "https://api.thenewsapi.com/v1/news/top?api_token=nY7SzuMYEPECPdnoIU6DX0l6TpyxdE1uswVNftU1&locale=us&limit=3";
            var response = await httpClient.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                //need to map json and fix it.
                newsToday = await response.Content.ReadFromJsonAsync<List<NewsToday>>();
            }
            return newsToday;
        }
    }
}
