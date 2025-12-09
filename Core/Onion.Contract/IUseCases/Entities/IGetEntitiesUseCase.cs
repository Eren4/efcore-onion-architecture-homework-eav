using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IUseCases.Entities
{
    public interface IGetEntitiesUseCase
    {
        public List<Task<Entity>> ExecuteAsync();
    }
}
