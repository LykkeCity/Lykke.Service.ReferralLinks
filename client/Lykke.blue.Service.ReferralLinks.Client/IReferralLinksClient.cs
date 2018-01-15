﻿
using Lykke.blue.Service.ReferralLinks.Client.AutorestClient.Models;
using Lykke.blue.Service.ReferralLinks.Client.Models;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
// interface intended for external usage

namespace Lykke.blue.Service.ReferralLinks.Client
{
    public interface IReferralLinksClient
    {
        Task<ReferralLinkDto> GetReferralLink(string id);
        Task<ReferralLinkDto> GetReferralLinkByUrl(string url);
        Task<object> GetReferralLinksStatisticsBySenderId(string senderClientId);
        Task<object> RequestGiftCoinsReferralLink(GiftCoinRequest request);
        Task<object> GroupGenerateGiftCoinLinks(GiftCoinRequestGroup request);
        Task<Microsoft.AspNetCore.Mvc.ObjectResult> RequestInvitationReferralLink(InvitationReferralLinkRequest request);
        Task<object> ClaimGiftCoins(string refLinkId, ClaimReferralLinkRequest request);
        Task<Microsoft.AspNetCore.Mvc.ObjectResult> ClaimInvitationLink(string refLinkId, ClaimReferralLinkRequest request);
        Task<object> GetGiftCoinReferralLinks(string senderClientId);
        
    }
}
