using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Entities;
using Onion.Contract.IRepositories;
using Onion.Domain.Models;

namespace Onion.Application.UseCases.Entities
{
    public class GetEntitiesUseCase : IGetEntitiesUseCase
    {
        private readonly IEntityRepository _repository;

        public GetEntitiesUseCase(IEntityRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EntityResultDTO>> ExecuteAsync()
        {
            List<Entity> values = await _repository.GetAllAsync();

            return values.Select(x => new EntityResultDTO
            {
                Id = x.Id,
                EntityName = x.EntityName
            }).ToList();
        }
    }
}
