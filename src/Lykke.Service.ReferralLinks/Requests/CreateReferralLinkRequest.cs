﻿using System;
using Lykke.Service.ReferralLinks.Core.Domain.ReferralLink;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Lykke.Service.ReferralLinks.Requests
{
    public class CreateReferralLinkRequest : IReferralLink
    {
        //REMARK: We do not need to allow someone to set Id. Id is set automatically.
        [IgnoreDataMember]
        public string Id { get; }

        [Required]
        public string Url { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [Required]
        public string SenderClientId { get; set; }

        [Required]
        public string Asset { get; set; }

        [Required]
        public bool? IsNewUser { get; set; }

        [Required]
        public ReferralLinkState State { get; set; }

        public decimal Amount { get; set; }

        public string ClaimingClientId { get; set; }

        [Required]
        public ReferralLinkType Type { get; set; }

        public string SenderTransactionId { get; set; }
    }
}
