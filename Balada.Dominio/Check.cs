using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balada.Dominio
{
    public class Check : EntityBase
    {
        public List<ItemCheck>? Items { get; set; }
        public DateTime Date { get; set; }
        public string? Customer { get; set; }
        public Table? Table { get; set; }
        public Employee? Employee { get; set; }
        
        public Guid PayCheck(string paymentMethod) => Payment.PayCheck(this, paymentMethod);
    }
}