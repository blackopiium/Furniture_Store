using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IFactoryService
    {
        Task<IEnumerable<FactoryDTO>> GetAllFactories();
        Task<FactoryDTO> GetFactory(int id);
        Task UpdateFactory(FactoryDTO factory);
        Task<int> AddFactory(FactoryDTO factory);
        Task DeleteFactory(int id);
        void Dispose();
    }
}
