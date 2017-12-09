// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LykkeReferralLinksService.
    /// </summary>
    public static partial class LykkeReferralLinksServiceExtensions
    {
            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object IsAlive(this ILykkeReferralLinksService operations)
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
            public static async Task<object> IsAliveAsync(this ILykkeReferralLinksService operations, CancellationToken cancellationToken = default(CancellationToken))
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
            public static object GetReferralLinkById(this ILykkeReferralLinksService operations, string id)
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
            public static async Task<object> GetReferralLinkByIdAsync(this ILykkeReferralLinksService operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinkByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
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
            public static object GetReferralLinkByUrl(this ILykkeReferralLinksService operations, string url)
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
            public static async Task<object> GetReferralLinkByUrlAsync(this ILykkeReferralLinksService operations, string url, CancellationToken cancellationToken = default(CancellationToken))
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
            /// <param name='request'>
            /// Sender client id by which we wanna get statistics.
            /// </param>
            public static object GetReferralLinksStatisticsBySenderId(this ILykkeReferralLinksService operations, RefLinkStatisticsRequest request = default(RefLinkStatisticsRequest))
            {
                return operations.GetReferralLinksStatisticsBySenderIdAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral links statistics by sender client id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// Sender client id by which we wanna get statistics.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetReferralLinksStatisticsBySenderIdAsync(this ILykkeReferralLinksService operations, RefLinkStatisticsRequest request = default(RefLinkStatisticsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinksStatisticsBySenderIdWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
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
            public static object RequestInvitationReferralLink(this ILykkeReferralLinksService operations, InvitationReferralLinkRequest request = default(InvitationReferralLinkRequest))
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
            public static async Task<object> RequestInvitationReferralLinkAsync(this ILykkeReferralLinksService operations, InvitationReferralLinkRequest request = default(InvitationReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequestInvitationReferralLinkWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
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
            public static object ClaimInvitationLink(this ILykkeReferralLinksService operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest))
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
            public static async Task<object> ClaimInvitationLinkAsync(this ILykkeReferralLinksService operations, string refLinkId, ClaimReferralLinkRequest request = default(ClaimReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ClaimInvitationLinkWithHttpMessagesAsync(refLinkId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
