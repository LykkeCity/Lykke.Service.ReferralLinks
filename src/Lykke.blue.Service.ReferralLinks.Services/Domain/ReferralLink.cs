﻿using Lykke.Blue.Service.ReferralLinks.Core.Domain.ReferralLink;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Blue.Service.ReferralLinks.Services.Domain
{
    public class ReferralLink : IReferralLink
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string SenderClientId { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Asset { get; set; }

        public double Amount { get; set; }

        public string SenderOffchainTransferId { get; set; }

        public string Type { get; set; }

        public string State { get; set; }

    }
}