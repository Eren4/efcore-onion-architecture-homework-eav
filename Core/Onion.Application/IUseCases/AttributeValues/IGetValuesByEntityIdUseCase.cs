using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Values;
using Onion.Domain.Models;

namespace Onion.Application.IUseCases.AttributeValues
{
    public interface IGetValuesByEntityIdUseCase
    {
        public Task<List<ValueResultDTO>> ExecuteAsync(int entityId);
    }
}
