using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.IUseCases.Attributes;
using Onion.Application.IUseCases.AttributeValues;
using Onion.Contract.IRepositories;

namespace Onion.Application.UseCases.AttributeValues
{
    public class CreateAttributeValueUseCase : ICreateAttributeValueUseCase
    {
        private readonly IAttributeValueRepository _repository;

        public CreateAttributeValueUseCase(IAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(int entityId, int attributeId, string value)
        {
            await _repository.CreateOrUpdateValueAsync(entityId, attributeId, value);
        }
    }
}
