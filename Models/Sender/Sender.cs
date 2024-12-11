using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Peer2PeerDelivery.Models.Sender
{
    public class Sender
    {
        [Key]
        public int IdSender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;

        public ICollection<Item>? Items { get; set; }
        public ICollection<Payment>? payments { get; set; }

    }
}
