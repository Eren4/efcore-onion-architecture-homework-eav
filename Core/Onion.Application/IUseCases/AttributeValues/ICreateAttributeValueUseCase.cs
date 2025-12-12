using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.IUseCases.AttributeValues
{
    public interface ICreateAttributeValueUseCase
    {
        public Task ExecuteAsync(int entityId, int attributeId, string value);
    }
}
