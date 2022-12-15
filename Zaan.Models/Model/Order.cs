using System;
using System.Collections.Generic;
using System.Text;

namespace Zaan.Models.Model
{
    public class Order
    {
        public int Id { get; set; }
        public double Discount { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public DateTime ReceiveTime { get; set; }
        public DateTime? DaliveredTime { get; set; }
        public Customer Customer { get; set; }
        public Saler Saler { get; set; }
        public int? ReviewId { get; set; }
        public Review Review { get; set; }
        public string PaymentMethod { get; set; }

    }

}
