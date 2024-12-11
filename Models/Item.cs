namespace Peer2PeerDelivery.Models
{
    public class Item
    {
        public int IdItem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string value { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public string Deadline { get; set; }
        public string DeliveryPriority { get; set; }    
        public string SpecialInstructions { get; set; }

    }
}
