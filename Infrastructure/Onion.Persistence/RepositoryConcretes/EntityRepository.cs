using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class EntityRepository : IEntityRepository
    {
        private readonly MyContext _context;

        public EntityRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<int> CreateEntityAsync(string entityName)
        {
            Entity entity = new Entity
            {
                EntityName = entityName
            };

            _context.Entities.Add(e);

            await _context.SaveChangesAsync();

            return e.EntityId;
        }

        public Task<Entity> GetEntityAsync(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
