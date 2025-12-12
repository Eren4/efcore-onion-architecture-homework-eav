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
    public class GetAttributesUseCase : IGetAttributesUseCase
    {
        private readonly IAttributeRepository _repository;

        public GetAttributesUseCase(IAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AttributeResultDTO>> ExecuteAsync()
        {
            List<EntityAttribute> values = await _repository.GetAllAsync();

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
