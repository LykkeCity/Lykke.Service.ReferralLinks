﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Service.ReferralLinks.Core.Domain.ReferralLink
{
    public interface IReferralLinkClaim
    {
        string Id { get; }
        string ReferralLinkId { get; }
        string RecipientClientId { get; }
        string RecipientTransactionId { get; }
        bool ShouldReceiveReward { get; }
        bool IsNewClient { get; }
    }
}
