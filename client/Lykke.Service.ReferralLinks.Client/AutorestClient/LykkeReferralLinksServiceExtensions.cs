// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ReferralLinks.Client.AutorestClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
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
            /// Get referral links by sender client id or state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderClientId'>
            /// Sender client id for which we wanna find referral links.
            /// </param>
            /// <param name='state'>
            /// State by which we wanna to find referral links.
            /// </param>
            public static IList<GetReferralLinkResponse> GetReferralLinksBySenderIdAndOrStatus(this ILykkeReferralLinksService operations, string senderClientId = default(string), string state = default(string))
            {
                return operations.GetReferralLinksBySenderIdAndOrStatusAsync(senderClientId, state).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral links by sender client id or state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderClientId'>
            /// Sender client id for which we wanna find referral links.
            /// </param>
            /// <param name='state'>
            /// State by which we wanna to find referral links.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<GetReferralLinkResponse>> GetReferralLinksBySenderIdAndOrStatusAsync(this ILykkeReferralLinksService operations, string senderClientId = default(string), string state = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinksBySenderIdAndOrStatusWithHttpMessagesAsync(senderClientId, state, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static CreateReferralLinkResponse CreateReferralLink(this ILykkeReferralLinksService operations, CreateReferralLinkRequest request = default(CreateReferralLinkRequest))
            {
                return operations.CreateReferralLinkAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateReferralLinkResponse> CreateReferralLinkAsync(this ILykkeReferralLinksService operations, CreateReferralLinkRequest request = default(CreateReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateReferralLinkWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna get.
            /// </param>
            public static GetReferralLinkResponse GetReferralLink(this ILykkeReferralLinksService operations, string id)
            {
                return operations.GetReferralLinkAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get referral link.
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
            public static async Task<GetReferralLinkResponse> GetReferralLinkAsync(this ILykkeReferralLinksService operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinkWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Change referral link state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna change state for.
            /// </param>
            /// <param name='state'>
            /// New referral link state.
            /// </param>
            public static void UpdateReferralLinkState(this ILykkeReferralLinksService operations, string id, string state)
            {
                operations.UpdateReferralLinkStateAsync(id, state).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Change referral link state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna change state for.
            /// </param>
            /// <param name='state'>
            /// New referral link state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateReferralLinkStateAsync(this ILykkeReferralLinksService operations, string id, string state, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateReferralLinkStateWithHttpMessagesAsync(id, state, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get referral links statistics by sender client id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='senderClientId'>
            /// Sender client id by which we wanna get statistics.
            /// </param>
            public static GetReferralLinksStatisticsBySenderIdResponse GetReferralLinksStatisticsBySenderId(this ILykkeReferralLinksService operations, string senderClientId)
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
            /// Sender client id by which we wanna get statistics.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetReferralLinksStatisticsBySenderIdResponse> GetReferralLinksStatisticsBySenderIdAsync(this ILykkeReferralLinksService operations, string senderClientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReferralLinksStatisticsBySenderIdWithHttpMessagesAsync(senderClientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set referral link Url.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna update url for.
            /// </param>
            /// <param name='url'>
            /// Url that we wanna set.
            /// </param>
            public static void SetReferralLinkUrl(this ILykkeReferralLinksService operations, string id, string url)
            {
                operations.SetReferralLinkUrlAsync(id, url).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set referral link Url.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of a referral link we wanna update url for.
            /// </param>
            /// <param name='url'>
            /// Url that we wanna set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetReferralLinkUrlAsync(this ILykkeReferralLinksService operations, string id, string url, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetReferralLinkUrlWithHttpMessagesAsync(id, url, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Claim gift coins.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static string ClaimGiftCoins(this ILykkeReferralLinksService operations, ClaimGiftCoinsRequest request = default(ClaimGiftCoinsRequest))
            {
                return operations.ClaimGiftCoinsAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Claim gift coins.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ClaimGiftCoinsAsync(this ILykkeReferralLinksService operations, ClaimGiftCoinsRequest request = default(ClaimGiftCoinsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ClaimGiftCoinsWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static string RequestReferralLink(this ILykkeReferralLinksService operations, RequestReferralLinkRequest request = default(RequestReferralLinkRequest))
            {
                return operations.RequestReferralLinkAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request referral link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RequestReferralLinkAsync(this ILykkeReferralLinksService operations, RequestReferralLinkRequest request = default(RequestReferralLinkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequestReferralLinkWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asset'>
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static void ApiTransfersChannelKeyGet(this ILykkeReferralLinksService operations, string asset = default(string), string clientId = default(string))
            {
                operations.ApiTransfersChannelKeyGetAsync(asset, clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asset'>
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTransfersChannelKeyGetAsync(this ILykkeReferralLinksService operations, string asset = default(string), string clientId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTransfersChannelKeyGetWithHttpMessagesAsync(asset, clientId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static void ApiTransfersTransferToLykkeWalletPost(this ILykkeReferralLinksService operations, TransferToLykkeWallet model = default(TransferToLykkeWallet))
            {
                operations.ApiTransfersTransferToLykkeWalletPostAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTransfersTransferToLykkeWalletPostAsync(this ILykkeReferralLinksService operations, TransferToLykkeWallet model = default(TransferToLykkeWallet), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTransfersTransferToLykkeWalletPostWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static void ApiTransfersProcessChannelPost(this ILykkeReferralLinksService operations, OffchainChannelProcessModel model = default(OffchainChannelProcessModel))
            {
                operations.ApiTransfersProcessChannelPostAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTransfersProcessChannelPostAsync(this ILykkeReferralLinksService operations, OffchainChannelProcessModel model = default(OffchainChannelProcessModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTransfersProcessChannelPostWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static void ApiTransfersFinalizetransferPost(this ILykkeReferralLinksService operations, OffchainFinalizeModel model = default(OffchainFinalizeModel))
            {
                operations.ApiTransfersFinalizetransferPostAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTransfersFinalizetransferPostAsync(this ILykkeReferralLinksService operations, OffchainFinalizeModel model = default(OffchainFinalizeModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTransfersFinalizetransferPostWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
