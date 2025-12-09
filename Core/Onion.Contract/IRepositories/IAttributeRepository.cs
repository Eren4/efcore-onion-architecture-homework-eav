using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IRepositories
{
    public interface IAttributeRepository : IRepository<EntityAttribute>
    {
        Task<int> CreateAttributeAsync(EntityAttribute attribute);
        Task<List<EntityAttribute>> GetAttributesForEntityNameAsync(string entityName);
    }
}
