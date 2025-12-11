using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Entities;
using Onion.Domain.Models;

namespace Onion.Application.IUseCases.Entities
{
    public interface IGetEntityByIdUseCase
    {
        public Task<EntityResultDTO> ExecuteAsync(int entityId);
    }
}
