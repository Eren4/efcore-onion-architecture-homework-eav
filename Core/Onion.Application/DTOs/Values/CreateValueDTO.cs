using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.DTOs.Values
{
    public class CreateValueDTO
    {
        public int EntityId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    }
}
