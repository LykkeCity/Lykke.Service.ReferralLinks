﻿using System.Threading.Tasks;
using Lykke.Service.ReferralLinks.Core.Domain.ReferralLink;
using AzureStorage;
using System;
using AutoMapper;
using Lykke.Service.ReferralLinks.AzureRepositories.DTOs;
using System.Collections.Generic;
using System.Linq;
using Lykke.SettingsReader;
using Lykke.Service.ReferralLinks.Core.Settings;
using Lykke.Service.ReferralLinks.Core.Settings.ServiceSettings;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace Lykke.Service.ReferralLinks.AzureRepositories.ReferralLink
{
    public class ReferralLinkRepository : IReferralLinkRepository
    {
        private readonly INoSQLTableStorage<ReferralLinkEntity> _referralLinkTable;

        public ReferralLinkRepository(INoSQLTableStorage<ReferralLinkEntity> referralLinkTable)
        {
            _referralLinkTable = referralLinkTable;
        }

        public static string GetPartitionKey() => "ReferallLink";

        public static string GetRowKey(string id)
        {
            return String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public async Task<string> ClaimGiftCoins(string referralLinkId, bool newUser, string claimingClientId)
        {
            var entity = await _referralLinkTable.GetDataAsync(GetPartitionKey(), GetRowKey(referralLinkId));
            entity.IsNewUser = newUser;
            entity.ClaimingClientId = claimingClientId;            

            await _referralLinkTable.InsertOrReplaceAsync(entity);

            return entity.State;
        }

        public async Task<IReferralLink> Create(IReferralLink referralLink)
        {
            var entity = Mapper.Map<ReferralLinkEntity>(referralLink);

            entity.PartitionKey = GetPartitionKey();
            entity.RowKey = GetRowKey(referralLink.Id);

            await _referralLinkTable.InsertAsync(entity);

            return Mapper.Map<ReferralLinkDto>(entity);
        }        

        public async Task Delete(string id)
        {
            await _referralLinkTable.DeleteAsync(GetPartitionKey(), GetRowKey(id));
        }

        public async Task<IReferralLink> Get(string id)
        {
            var entity = await _referralLinkTable.GetDataAsync(GetPartitionKey(), GetRowKey(id));

            return Mapper.Map<ReferralLinkDto>(entity);
        }

        public async Task<IEnumerable<IReferralLink>> Get(string senderClientId, string state)
        {
            var entities = await _referralLinkTable.GetDataAsync(
                GetPartitionKey(),
                x => (String.IsNullOrEmpty(senderClientId) || x.SenderClientId == senderClientId) && (String.IsNullOrEmpty(state) || x.State == state)
            );

            return Mapper.Map<IEnumerable<ReferralLinkDto>>(entities);
        }

        public async Task<IReferralLinksStatistics> GetReferralLinksStatisticsBySenderId(string senderClientId)
        {
            var referralLinks = await _referralLinkTable.GetDataAsync(
                GetPartitionKey(),
                x => x.SenderClientId == senderClientId
            );

            var numberOfInvitationSent = referralLinks.Count(x => x.State == ReferralLinkState.SentToLykkeSharedWallet.ToString());
            var numberOfInvitationAccepted = referralLinks.Count(x => x.State == ReferralLinkState.Claimed.ToString());
            var numberOfNewUsersBroughtIn = referralLinks.Count(x => x.IsNewUser.HasValue && x.IsNewUser.Value);
            var amountOfCoinsDistributed = referralLinks
                .Where(x => x.State == ReferralLinkState.Claimed.ToString())
                .Sum(x => x.Amount);

            return new ReferralLinksStatisticsDto
            {
                AmountOfCoinsDistributed = amountOfCoinsDistributed.HasValue ? amountOfCoinsDistributed.Value : 0,
                NumberOfInvitationAccepted = numberOfInvitationAccepted,
                NumberOfInvitationsSent = numberOfInvitationSent,
                NumberOfNewUsersBroughtIn = numberOfNewUsersBroughtIn
            };
        }

        public async Task<bool> IsReferralLinksNumberLimitReached(string senderClientId)
        {
            var numberOfCreatedReflinks = (await _referralLinkTable.GetDataAsync(
                GetPartitionKey(),
                x => x.SenderClientId == senderClientId 
                    && x.State == ReferralLinkState.Created.ToString()
                    && x.Type == ReferralLinkType.Invitation.ToString()
                    && x.Timestamp.Date == DateTime.Today
            )).Count();

            return numberOfCreatedReflinks >= 1;
        }

        public async Task ReturnCoinsToSender()
        {
            var entities = await _referralLinkTable.GetDataAsync(
                GetPartitionKey(), 
                x => x.ExpirationDate < DateTime.UtcNow && x.State != ReferralLinkState.CoinsReturnedToSender.ToString()
            );

            foreach (var entity in entities)
            {
                await ClaimGiftCoins(entity.Id, false, entity.SenderClientId);
                await UpdateState(entity.Id, ReferralLinkState.CoinsReturnedToSender.ToString());
            }
        }

        public async Task SetUrl(string id, string url)
        {
            var entity = await _referralLinkTable.GetDataAsync(GetPartitionKey(), GetRowKey(id));
            entity.Url = url;

            await _referralLinkTable.InsertOrReplaceAsync(entity);
        }

        public async Task<IReferralLink> Update(IReferralLink referralLink)
        {
            var result = await _referralLinkTable.MergeAsync(GetPartitionKey(), GetRowKey(referralLink.Id), x =>
            {
                Mapper.Map(referralLink, x);

                return x;
            });

            return Mapper.Map<ReferralLinkDto>(result);
        }

        public async Task UpdateState(string id, string state)
        {
            var entity = await _referralLinkTable.GetDataAsync(GetPartitionKey(), GetRowKey(id));
            entity.State = state;

            await _referralLinkTable.InsertOrReplaceAsync(entity);
        }
    }
}
