using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balada.Dominio
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}