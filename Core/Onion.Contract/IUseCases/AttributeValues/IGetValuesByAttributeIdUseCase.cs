using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.IUseCases.AttributeValues
{
    public interface IGetValuesByAttributeIdUseCase
    {
        public Task<List<AttributeValue>> ExecuteAsync(int attributeId);
    }
}
