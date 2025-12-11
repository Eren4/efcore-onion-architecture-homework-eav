using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.DTOs.Attributes
{
    public class AttributeResultDTO
    {
        public int EntityId { get; set; }
        public string AttributeName { get; set; }
        public string DataType { get; set; }
    }
}
