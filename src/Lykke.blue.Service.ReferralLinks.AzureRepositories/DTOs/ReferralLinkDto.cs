﻿using System;
using Lykke.Blue.Service.ReferralLinks.Core.Domain.ReferralLink;

namespace Lykke.Blue.Service.ReferralLinks.AzureRepositories.DTOs
{
    public class ReferralLinkDto : IReferralLink
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string SenderClientId { get; set; }

        public string Asset { get; set; }

        public string State { get; set; }

        public double Amount { get; set; }

        public string Type { get; set; }

        public string SenderOffchainTransferId { get; set; }
    }
}