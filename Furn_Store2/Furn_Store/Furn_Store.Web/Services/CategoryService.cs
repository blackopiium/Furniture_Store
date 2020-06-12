using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Furn_Store.Web.Services
{
    public class CategoryService
    {
        public HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryViewModel>> GetCategories()
        {
            var response = await _httpClient.GetAsync($"api/category");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<CategoryViewModel>>(responseContent);
        }
        public async Task<string> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/category/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
    }
}
