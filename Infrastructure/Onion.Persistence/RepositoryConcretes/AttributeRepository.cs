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

        public Task<int> CreateAttributeAsync(EntityAttribute attribute)
        {
            _context.EntityAttributes.Add(attribute);

            return _context.SaveChangesAsync().ContinueWith(t => attribute.Id);
        }

        public Task<List<EntityAttribute>> GetAttributesForEntityNameAsync(string entityName)
        {
            Entity entity = _context.Entities.Where(e => e.EntityName == entityName).FirstOrDefault();

            return Task.FromResult(entity.EntityAttributes);
        }
    }
}
