using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Attributes;
using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Attributes;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;
using Onion.Persistence.RepositoryConcretes;

namespace Onion.Application.UseCases.Attributes
{
    public class GetAttributesByEntityIdUseCase : IGetAttributesByEntityIdUseCase
    {
        private readonly IAttributeRepository _repository;

        public GetAttributesByEntityIdUseCase(IAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AttributeResultDTO>> ExecuteAsync(int entityId)
        {
            List<EntityAttribute> values = await _repository.GetAttributesForEntityIdAsync(entityId);

            return values.Select(x => new AttributeResultDTO
            {
                Id = x.Id,
                AttributeName = x.AttributeName,
                DataType = x.DataType,
                EntityId = x.EntityId
            }).ToList();
        }
    }
}
