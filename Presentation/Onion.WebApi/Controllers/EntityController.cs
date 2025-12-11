using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Entities;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private ICreateEntityUseCase _createEntityUseCase;
        private IGetEntitiesUseCase _getEntitiesUseCase;
        private IGetEntityByIdUseCase _getEntityByIdUseCase;

        public EntityController(IGetEntitiesUseCase getEntitiesUseCase, IGetEntityByIdUseCase getEntityByIdUseCase, ICreateEntityUseCase createEntityUseCase)
        {
            _getEntitiesUseCase = getEntitiesUseCase;
            _getEntityByIdUseCase = getEntityByIdUseCase;
            _createEntityUseCase = createEntityUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntities()
        {
            List<EntityResultDTO> result = await _getEntitiesUseCase.ExecuteAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEntityById([FromBody] int id)
        {
            EntityResultDTO result = await _getEntityByIdUseCase.ExecuteAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity([FromBody] string name)
        {
            await _createEntityUseCase.ExecuteAsync(name);

            return Ok("Entity created");
        }
    }
}
