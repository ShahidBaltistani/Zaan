namespace Zaan.Models.Model
{
    public class DeliveryBoy :User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
