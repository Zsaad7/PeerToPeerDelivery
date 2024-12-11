﻿namespace Peer2PeerDelivery.Models
{
    public class Payment
    {
        /// q definir apr
        public int IdPayement { get; set; }
        public decimal Montant { get; set; }
        public DateTime DatePaiement { get; set; }
        public string ModePaiement { get; set; } = string.Empty; // Carte de crédit, virement, etc.
        public string ReferencePaiement { get; set; } = string.Empty; // Numéro de transaction, etc.
        public string Etat { get; set; } = string.Empty;



    }
}
