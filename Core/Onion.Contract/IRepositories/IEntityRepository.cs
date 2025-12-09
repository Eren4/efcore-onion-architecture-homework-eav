using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IRepositories
{
    public interface IEntityRepository
    {
        Task<int> CreateEntityAsync(string entityName);
        Task<Entity> GetEntityAsync(int entityId);
    }
}
