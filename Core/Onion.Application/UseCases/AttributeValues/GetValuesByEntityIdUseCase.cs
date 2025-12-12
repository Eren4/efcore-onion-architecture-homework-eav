using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Entities;
using Onion.Application.DTOs.Values;
using Onion.Application.IUseCases.AttributeValues;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;

namespace Onion.Application.UseCases.AttributeValues
{
    public class GetValuesByEntityIdUseCase : IGetValuesByEntityIdUseCase
    {
        private readonly IAttributeValueRepository _repository;

        public GetValuesByEntityIdUseCase(IAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ValueResultDTO>> ExecuteAsync(int entityId)
        {
            List<AttributeValue> values = await _repository.GetValuesForEntityIdAsync(entityId);

            return values.Select(x => new ValueResultDTO
            {
                Id = x.Id,
                AttributeId = x.AttributeId,
                EntityId = x.EntityId,
                Value = x.Value,
            }).ToList();
        }
    }
}
