using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategories();
        Task<CategoryDTO> GetCategory(int id);
        Task UpdateCategory(CategoryDTO category);
        Task<int> AddCategory(CategoryDTO category);
        Task DeleteCategory(int id);
        void Dispose();
    }
}
