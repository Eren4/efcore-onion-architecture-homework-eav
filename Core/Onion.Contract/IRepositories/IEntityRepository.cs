using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IRepositories
{
    public interface IEntityRepository : IRepository<Entity>
    {
        Task<int> CreateEntityAsync(string entityName);
        Task<Entity> GetEntityByIdAsync(int entityId);
    }
}
