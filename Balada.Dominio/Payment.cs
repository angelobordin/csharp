using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balada.Dominio
{
    public class Payment : EntityBase
    { 
        public decimal Value { get; private set; }
        public string? Forma { get; private set; }
        public bool IsPaid { get; private set; }
        public Check? Check { get; private set; }
        public string PaymentMethod { get; }

        public Payment(decimal value, string paymentMethod, bool isPaid)
        {
            Value = value;
            PaymentMethod = paymentMethod;
            IsPaid = isPaid;
        }

        public static Guid PayCheck(Check check, string paymentMethod) {
            var payment = new Payment(check.Items.Sum(i => i.TotalValue), paymentMethod, true);
            return payment.Id;
        }
    }
}