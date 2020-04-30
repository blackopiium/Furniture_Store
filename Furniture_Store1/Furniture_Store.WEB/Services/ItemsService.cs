using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Business.DTO;
using System.Net.Http;
using System.Text.Json;

namespace Furniture_Store.WEB.Services
{
    public class ItemsService
    {
        public HttpClient _httpClient;
        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ItemDTO>> GetAllItems()
        {
            var response = await _httpClient.GetAsync("api/Item");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ItemDTO>>(responseContent);
        }
        public async Task<ItemDTO> GetItemById(int id)
        {
            var response = await _httpClient.GetAsync($"api/Item/{id}");
            response.EnsureSuccessStatusCode();
            using var responceContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<ItemDTO>(responceContent);
        }
    }
}
