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
    public class AttributeRepository : BaseRepository<EntityAttribute>, IAttributeRepository
    {
        private readonly MyContext _context;

        public AttributeRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public Task CreateAttributeAsync(int entityId, string attributeName, string dataType)
        {
            Entity attributeEntity = _context.Entities.Find(entityId);

            EntityAttribute attribute = new EntityAttribute()
            {
                AttributeName = attributeName,
                DataType = dataType,
                EntityId = entityId,

                Entity = attributeEntity,
                AttributeValues = new List<AttributeValue>()
            };

            _context.EntityAttributes.Add(attribute);

            return _context.SaveChangesAsync().ContinueWith(t => attribute.Id);
        }

        public Task<List<EntityAttribute>> GetAttributesForEntityIdAsync(int entityId)
        {
            Entity entity = _context.Entities.Where(e => e.Id == entityId).FirstOrDefault();

            return Task.FromResult(entity.EntityAttributes);
        }
    }
}
