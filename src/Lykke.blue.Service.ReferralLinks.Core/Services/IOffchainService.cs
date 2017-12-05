﻿using System.Threading.Tasks;
using Lykke.blue.Service.ReferralLinks.Core.Domain.Offchain;

namespace Lykke.blue.Service.ReferralLinks.Core.Services
{
    public interface IOffchainService
    {
        Task<OffchainResult> CreateDirectTransfer(string clientId, string assetId, decimal amount, string prevTempPrivateKey);
        Task<OffchainResult> CreateHubCommitment(string clientId, string transferId, string signedChannel);
        Task<OffchainResult> Finalize(string clientId, string transferId, string clientRevokePubKey, string clientRevokeEncryptedPrivateKey, string signedCommitment);
        Task<OffchainResultOrder> GetResultOrderFromTransfer(string transferId);
    }
}
