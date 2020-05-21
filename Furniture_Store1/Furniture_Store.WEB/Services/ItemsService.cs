using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Business.DTO;
using System.Net.Http;
using System.Text.Json;
using Furniture_Store.WEB.ViewModels;

namespace Furniture_Store.WEB.Services
{
    public class ItemsService
    {
        public HttpClient _httpClient;
        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ItemViewModel>> GetAllItems()
        {
            var response = await _httpClient.GetAsync("api/Item");
            if (!response.IsSuccessStatusCode)
                return null;
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ItemViewModel>>(responseContent);
        }
        public async Task<ItemViewModel> GetItemById(int id)
        {
            var response = await _httpClient.GetAsync($"api/Item/{id}");
            if (!response.IsSuccessStatusCode)
                return null;
            using var responceContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<ItemViewModel>(responceContent);
        }
    }
}
