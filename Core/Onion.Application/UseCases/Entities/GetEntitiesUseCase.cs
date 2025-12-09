using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Contract.IRepositories;

namespace Onion.Application.UseCases.Entities
{
    public class GetEntitiesUseCase
    {
        private readonly IEntityRepository _repository;

        public GetEntitiesUseCase(IEntityRepository repository)
        {
            _repository = repository;
        }

        public Task<int> ExecuteAsync(string entityType)
        {
        }
    }
}
