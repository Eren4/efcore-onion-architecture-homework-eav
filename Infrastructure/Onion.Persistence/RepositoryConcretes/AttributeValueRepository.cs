using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;

namespace Onion.Persistence.RepositoryConcretes
{
    public class AttributeValueRepository : IAttributeValueRepository
    {
        public Task CreateOrUpdateValueAsync(int entityId, int attributeId, string value)
        {
            throw new NotImplementedException();
        }

        public Task<List<AttributeValue>> GetValuesForEntityAsync(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
