using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs.Attributes;
using Onion.Application.DTOs.Entities;
using Onion.Application.IUseCases.Attributes;
using Onion.Application.IUseCases.Entities;
using Onion.Application.UseCases.Attributes;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private ICreateAttributeUseCase _createAttributeUseCase;
        private IGetAttributesUseCase _getAttributesUseCase;
        private IGetAttributesByEntityIdUseCase _getAttributesByEntityIdUseCase;

        public AttributeController(IGetAttributesUseCase getAttributesUseCase,
            IGetAttributesByEntityIdUseCase getAttributesByEntityIdUseCase,
            ICreateAttributeUseCase createAttributeUseCase)
        {
            _getAttributesUseCase = getAttributesUseCase;
            _getAttributesByEntityIdUseCase = getAttributesByEntityIdUseCase;
            _createAttributeUseCase = createAttributeUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAttributes()
        {
            List<AttributeResultDTO> result = await _getAttributesUseCase.ExecuteAsync();

            return Ok(result);
        }

        [HttpGet("{entityId}")]
        public async Task<IActionResult> GetAttributesByEntityId(int entityId)
        {
            List<AttributeResultDTO> result = await _getAttributesByEntityIdUseCase.ExecuteAsync(entityId);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttribute([FromBody] CreateAttributeDTO dto)
        {
            int entityId = dto.EntityId;
            string attributeName = dto.AttributeName;
            string dataType = dto.DataType;

            await _createAttributeUseCase.ExecuteAsync(entityId, attributeName, dataType);

            return Ok("Attribute created");
        }
    }
}
