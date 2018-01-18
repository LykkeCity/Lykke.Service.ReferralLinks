// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient
{
    using Lykke.blue;
    using Lykke.blue.Service;
    using Lykke.blue.Service.ReferralLinks;
    using Lykke.blue.Service.ReferralLinks.Client;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LykkeBlueServiceReferralLinks.
    /// </summary>
    public static partial class LykkeBlueServiceReferralLinksExtensions
    {
            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object IsAlive(this ILykkeBlueServiceReferralLinks operations)
            {
                return operations.IsAliveAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsAliveAsync(this ILykkeBlueServiceReferralLinks operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IsAliveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get referral link by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna get.
            /// </param>
            public static object GetReferralLinkById(this ILykkeBlueServiceReferralLinks operations, string id)
            {
                return operations.GetReferralLinkByIdAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral link by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetReferralLinkByIdAsync(this ILykkeBlueServiceReferralLinks operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinkByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get mass generated referral link by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderId'>
            /// The Id of the referral link group
            /// </param>
            public static object GetGroupReferralLinkBySenderId(this ILykkeBlueServiceReferralLinks operations, string senderId)
            {
                return operations.GetGroupReferralLinkBySenderIdAsync(senderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get mass generated referral link by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderId'>
            /// The Id of the referral link group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetGroupReferralLinkBySenderIdAsync(this ILykkeBlueServiceReferralLinks operations, string senderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupReferralLinkBySenderIdWithHttpMessagesAsync(senderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get referral link by url.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// Url of the referral link we want to get.
            /// </param>
            public static object GetReferralLinkByUrl(this ILykkeBlueServiceReferralLinks operations, string url)
            {
                return operations.GetReferralLinkByUrlAsync(url).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral link by url.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// Url of the referral link we want to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetReferralLinkByUrlAsync(this ILykkeBlueServiceReferralLinks operations, string url, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinkByUrlWithHttpMessagesAsync(url, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get referral links statistics by sender client id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderClientId'>
            /// Sender client id by which we want to get statistics.
            /// </param>
            public static object GetReferralLinksStatisticsBySenderId(this ILykkeBlueServiceReferralLinks operations, string senderClientId = default(string))
            {
                return operations.GetReferralLinksStatisticsBySenderIdAsync(senderClientId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral links statistics by sender client id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderClientId'>
            /// Sender client id by which we want to get statistics.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetReferralLinksStatisticsBySenderIdAsync(this ILykkeBlueServiceReferralLinks operations, string senderClientId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinksStatisticsBySenderIdWithHttpMessagesAsync(senderClientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generate Gift Coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object GroupGenerateGiftCoinLinks(this ILykkeBlueServiceReferralLinks operations, GiftCoinRequestGroup request = default(GiftCoinRequestGroup))
            {
                return operations.GroupGenerateGiftCoinLinksAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate Gift Coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GroupGenerateGiftCoinLinksAsync(this ILykkeBlueServiceReferralLinks operations, GiftCoinRequestGroup request = default(GiftCoinRequestGroup), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GroupGenerateGiftCoinLinksWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generate Gift Coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object RequestGiftCoinsReferralLink(this ILykkeBlueServiceReferralLinks operations, GiftCoinRequest request = default(GiftCoinRequest))
            {
                return operations.RequestGiftCoinsReferralLinkAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate Gift Coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RequestGiftCoinsReferralLinkAsync(this ILykkeBlueServiceReferralLinks operations, GiftCoinRequest request = default(GiftCoinRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequestGiftCoinsReferralLinkWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request invitation referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object RequestInvitationReferralLink(this ILykkeBlueServiceReferralLinks operations, InvitationReferralLinkRequest request = default(InvitationReferralLinkRequest))
            {
                return operations.RequestInvitationReferralLinkAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request invitation referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RequestInvitationReferralLinkAsync(this ILykkeBlueServiceReferralLinks operations, InvitationReferralLinkRequest request = default(InvitationReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequestInvitationReferralLinkWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Claim gift coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refLinkId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object ClaimGiftCoins(this ILykkeBlueServiceReferralLinks operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest))
            {
                return operations.ClaimGiftCoinsAsync(refLinkId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Claim gift coins referral link
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refLinkId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ClaimGiftCoinsAsync(this ILykkeBlueServiceReferralLinks operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ClaimGiftCoinsWithHttpMessagesAsync(refLinkId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Claim invitation referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refLinkId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object ClaimInvitationLink(this ILykkeBlueServiceReferralLinks operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest))
            {
                return operations.ClaimInvitationLinkAsync(refLinkId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Claim invitation referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refLinkId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ClaimInvitationLinkAsync(this ILykkeBlueServiceReferralLinks operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ClaimInvitationLinkWithHttpMessagesAsync(refLinkId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
