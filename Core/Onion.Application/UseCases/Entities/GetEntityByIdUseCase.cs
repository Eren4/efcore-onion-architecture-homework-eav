using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Entities;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;

namespace Onion.Application.UseCases.Entities
{
    public class GetEntityByIdUseCase : IGetEntityByIdUseCase
    {
        private readonly IEntityRepository _repository;

        public GetEntityByIdUseCase(IEntityRepository repository)
        {
            _repository = repository;
        }

        public async Task<EntityResultDTO> ExecuteAsync(int entityId)
        {
            Entity value = await _repository.GetEntityByIdAsync(entityId);

            if(value == null)
            {
                throw new Exception("Entity doesn't exist");
            }

            return new EntityResultDTO
            {
                Id = value.Id,
                EntityName = value.EntityName
            };
        }
    }
}
