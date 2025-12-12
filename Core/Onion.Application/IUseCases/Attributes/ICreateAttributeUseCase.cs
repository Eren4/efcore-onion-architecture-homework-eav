using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.IUseCases.Attributes
{
    public interface ICreateAttributeUseCase
    {
        public Task ExecuteAsync(int entityId, string attributeName, string dataType);
    }
}
