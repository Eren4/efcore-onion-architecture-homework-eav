using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Models
{
    public class Entity : BaseEntity
    {
        public string EntityName { get; set; }

        // Relational properties
        public virtual List<EntityAttribute> EntityAttributes { get; set; }
        public virtual List<AttributeValue> AttributeValues { get; set; }
    }
}
