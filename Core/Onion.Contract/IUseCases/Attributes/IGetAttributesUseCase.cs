using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IUseCases.Attributes
{
    public interface IGetAttributesUseCase
    {
        public List<Task<EntityAttribute>> ExecuteAsync();
    }
}
