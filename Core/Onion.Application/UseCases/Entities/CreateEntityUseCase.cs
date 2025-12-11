using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Entities;
using Onion.Contract.IRepositories;

namespace Onion.Application.UseCases.Entities
{
    public class CreateEntityUseCase : ICreateEntityUseCase
    {
        private readonly IEntityRepository _repository;

        public CreateEntityUseCase(IEntityRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(string entityName)
        {
            await _repository.CreateEntityAsync(entityName);
        }
    }
}
