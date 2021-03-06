﻿using Lykke.blue.Service.ReferralLinks.Core.Domain.ReferralLink;

namespace Lykke.blue.Service.ReferralLinks.AzureRepositories.DTOs
{
    public class ReferralLinkClaimsDto : IReferralLinkClaim
    {
        public string ReferralLinkId { get; set; }

        public string RecipientClientId { get; set; }

        public bool ShouldReceiveReward { get; set; }

        public bool IsNewClient { get; set; }

        public string Id { get; set; }

        public string RecipientTransactionId { get; set; }
    }
}
