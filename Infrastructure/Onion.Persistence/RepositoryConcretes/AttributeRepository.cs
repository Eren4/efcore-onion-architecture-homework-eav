using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;

namespace Onion.Persistence.RepositoryConcretes
{
    public class AttributeRepository : IAttributeRepository
    {
        public Task<int> CreateAttributeAsync(EntityAttribute attribute)
        {
            throw new NotImplementedException();
        }

        public Task<List<EntityAttribute>> GetAttributesForEntityTypeAsync(string entityType)
        {
            throw new NotImplementedException();
        }
    }
}
