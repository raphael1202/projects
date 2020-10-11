using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryDate { get; set; }
        
        public int PaymentTypeId { get; set; }

        /// <summary>
        /// An Order must have one item or many items
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            ClearMessages();

            if (!OrderItems.Any())
                AddValidation("Warning: Order must have an item");
        }
    }
}
