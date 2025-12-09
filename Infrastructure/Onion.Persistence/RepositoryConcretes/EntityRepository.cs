using Onion.Contract.IRepositories;
using Onion.Domain.Models;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class EntityRepository : BaseRepository<Entity>, IEntityRepository
    {
        private readonly MyContext _context;

        public EntityRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreateEntityAsync(string entityName)
        {
            Entity entity = new Entity
            {
                EntityName = entityName
            };

            _context.Entities.Add(entity);

            await _context.SaveChangesAsync();

            return entity.EntityId;
        }

        public async Task<Entity> GetEntityByIdAsync(int entityId)
        {
            return await _context.Entities.FindAsync(entityId);
        }
    }
}
