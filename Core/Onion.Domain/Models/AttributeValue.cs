using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Models
{
    public class AttributeValue : BaseEntity
    {
        public int? EntityId { get; set; }
        public int? AttributeId { get; set; }
        public string Value { get; set; }

        // Relational fields
        public virtual Entity Entity { get; set; }
        public virtual EntityAttribute EntityAttribute { get; set; }
    }
}
