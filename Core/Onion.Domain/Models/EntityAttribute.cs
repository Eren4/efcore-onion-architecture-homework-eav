using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Models
{
    public class EntityAttribute : BaseEntity
    {
        public int EntityId { get; set; }
        public string AttributeName { get; set; }
        public string DataType { get; set; }

        // Relational properties
        public Entity Entity { get; set; }
    }
}
