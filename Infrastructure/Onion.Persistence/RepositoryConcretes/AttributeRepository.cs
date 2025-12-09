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
    public class AttributeRepository : IAttributeRepository
    {
        private readonly MyContext _context;

        public AttributeRepository(MyContext context)
        {
            _context = context;
        }

        public Task<int> CreateAttributeAsync(EntityAttribute attribute)
        {
            _context.EntityAttributes.Add(attribute);

            return _context.SaveChangesAsync().ContinueWith(t => attribute.AttributeId);
        }

        public Task<List<EntityAttribute>> GetAttributesForEntityTypeAsync(string entityName)
        {
            return _context.EntityAttributes
                .Where(a => a.Entity.EntityName == entityName)
                .ToListAsync();
        }
    }
}
