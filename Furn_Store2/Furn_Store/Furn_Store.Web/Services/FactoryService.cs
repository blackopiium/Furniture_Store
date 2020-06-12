using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Furn_Store.Web.Services
{
    public class FactoryService
    {

        public HttpClient _httpClient;
        public FactoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FactoryViewModel>> GetFactories()
        {
            var response = await _httpClient.GetAsync($"api/factory");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<FactoryViewModel>>(responseContent);
        }
        public async Task<string> GetFactoryById(int id)
        {
            var response = await _httpClient.GetAsync($"api/factory/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
    }
}
