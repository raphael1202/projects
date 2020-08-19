using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public int PaymentTypeId { get; set; }

        /// <summary>
        /// An Order must have one item or many items
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
