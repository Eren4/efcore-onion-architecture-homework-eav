using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IRepositories
{
    public interface IAttributeValueRepository
    {
        Task CreateOrUpdateValueAsync(int entityId, int attributeId, string value);
        Task<List<AttributeValue>> GetValuesForEntityAsync(int entityId);
    }
}
