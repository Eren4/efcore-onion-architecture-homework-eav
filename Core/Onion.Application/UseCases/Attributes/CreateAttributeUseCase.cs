using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.IUseCases.Attributes;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;
using Onion.Persistence.RepositoryConcretes;

namespace Onion.Application.UseCases.Attributes
{
    public class CreateAttributeUseCase : ICreateAttributeUseCase
    {
        private readonly IAttributeRepository _repository;

        public CreateAttributeUseCase(IAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(int entityId, string attributeName, string dataType)
        {
            await _repository.CreateAttributeAsync(entityId, attributeName, dataType);
        }
    }
}
