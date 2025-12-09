using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Contract.IUseCases.Entities
{
    public interface ICreateEntityUseCase
    {
        Task<int> ExecuteAsync(string entityName);
    }
}
