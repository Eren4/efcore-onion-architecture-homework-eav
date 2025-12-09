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
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly MyContext _context;
        protected readonly DbSet<T> _dbSet;

        protected BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
