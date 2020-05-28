using Furn_Store.Data.Parameters;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Furn_Store.Web.Services
{
    public class ItemsService
    {
        public HttpClient _httpClient;
        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ItemViewModel>> GetAllItems(ItemParameters parameters)
        {
            var response = await _httpClient.GetAsync("api/Item?PageSize={parameters.PageSize}&PageNumber={parameters.PageNumber}&MinPrice={parameters.MinPrice}&MaxPrice={parameters.MaxPrice}&OrderBy={parameters.OrderBy}");
            if (!response.IsSuccessStatusCode)
                return null;
            //response.EnsureSuccessStatusCode();
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
