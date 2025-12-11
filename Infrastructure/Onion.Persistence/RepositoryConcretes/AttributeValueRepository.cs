using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class AttributeValueRepository : BaseRepository<AttributeValue>, IAttributeValueRepository
    {
        private readonly MyContext _context;

        public AttributeValueRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public async Task CreateOrUpdateValueAsync(int entityId, int attributeId, string value)
        {
            AttributeValue? attributeValue = await _context.AttributeValues
                .FirstOrDefaultAsync(x => x.EntityId == entityId && x.AttributeId == attributeId);

            Entity entity = _context.Entities.Find(entityId)!;
            EntityAttribute attribute = _context.EntityAttributes.Find(attributeId)!;

            if (attributeValue == null)
            {
                AttributeValue attributeValue1 = new AttributeValue
                {
                    AttributeId = attributeId,
                    Value = value,

                    EntityId = entityId,

                    Entity = entity,
                    EntityAttribute = attribute
                };

                _context.AttributeValues.Add(attributeValue1);
            }
            else
            {
                attributeValue.Value = value;
            }

            await _context.SaveChangesAsync();
        }

        public Task<List<AttributeValue>> GetValuesForEntityIdAsync(int entityId)
        {
            return _context.AttributeValues
                .Where(x => x.EntityId == entityId)
                .ToListAsync();
        }
    }
}
