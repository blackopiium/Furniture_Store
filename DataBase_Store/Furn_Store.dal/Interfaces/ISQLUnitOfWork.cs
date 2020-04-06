using System;
using System.Collections.Generic;
using System.Text;
using Furnit.Interfaces.SQLInterfaces.ISQLRepositories;

namespace Furnit.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLItemsRepository SQLItemsRepository {get; }
        void Complete();
    }
}
