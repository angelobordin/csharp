using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balada.Dominio
{
    public class ItemCheck : EntityBase
    {
        // public Product Product { get; set; }
        public Check Check { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public decimal UnitValue { get; private set; }
        public decimal TotalValue { get => Quantity * UnitValue; }


        public ItemCheck(Check check, int quantity, string description, decimal unitValue)
        {
            Check = check;
            Quantity = quantity;
            Description = description;
            UnitValue = unitValue;
            // Product = product;
        }
    }
}