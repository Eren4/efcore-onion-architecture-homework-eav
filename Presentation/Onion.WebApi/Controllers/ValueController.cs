using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs.Entities;
using Onion.Application.DTOs.Values;
using Onion.Application.IUseCases.AttributeValues;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private ICreateAttributeValueUseCase _createAttributeValueUseCase;
        private IGetValuesByEntityIdUseCase _getValuesByEntityIdUseCase;

        public ValueController(ICreateAttributeValueUseCase createAttributeValueUseCase,
            IGetValuesByEntityIdUseCase getValuesByEntityIdUseCase)
        {
            _createAttributeValueUseCase = createAttributeValueUseCase;
            _getValuesByEntityIdUseCase = getValuesByEntityIdUseCase;
        }

        [HttpGet("{entityId}")]
        public async Task<IActionResult> GetValuesByEntityId(int entityId)
        {
            List<ValueResultDTO> result = await _getValuesByEntityIdUseCase.ExecuteAsync(entityId);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateValue(CreateValueDTO dto)
        {
            int entityId = dto.EntityId;
            int attributeId = dto.AttributeId;
            string value = dto.Value;

            await _createAttributeValueUseCase.ExecuteAsync(entityId, attributeId, value);

            return Ok("Value created");
        }
    }
}
