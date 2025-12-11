using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs.Attributes;
using Onion.Domain.Models;

namespace Onion.Application.IUseCases.Attributes
{
    public interface IGetAttributesUseCase
    {
        public List<Task<AttributeResultDTO>> ExecuteAsync();
    }
}
