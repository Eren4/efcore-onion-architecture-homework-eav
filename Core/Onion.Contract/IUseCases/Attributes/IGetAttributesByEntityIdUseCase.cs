using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IUseCases.Attributes
{
    public interface IGetAttributesByEntityIdUseCase
    {
        public List<Task<EntityAttribute>> ExecuteAsync(int entityId);
    }
}
