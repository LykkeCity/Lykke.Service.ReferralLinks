﻿using System;
using System.Threading.Tasks;

namespace Core.BitCoin.BitcoinApi.Models
{
    public class IssueData
    {
        public Guid? TransactionId { get; set; }
        public string Address { get; set; }
        public string AssetId { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransferData
    {
        public Guid? TransactionId { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public string AssetId { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransferAllData
    {
        public Guid? TransactionId { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
    }

    public class DestroyData
    {
        public Guid? TransactionId { get; set; }
        public string Address { get; set; }
        public string AssetId { get; set; }
        public decimal Amount { get; set; }
    }

    public class SwapData
    {
        public Guid? TransactionId { get; set; }
        public string Multisig1 { get; set; }
        public string AssetId1 { get; set; }
        public decimal Amount1 { get; set; }
        public string Multisig2 { get; set; }
        public string AssetId2 { get; set; }
        public decimal Amount2 { get; set; }
    }

    public class RetryData
    {
        public Guid TransactionId { get; set; }
    }

    public class TransactionRepsonse
    {
        public Guid? TransactionId { get; set; }
    }

    public class OnchainResponse
    {
        public TransactionRepsonse Transaction { get; set; }
        public ErrorResponse Error { get; set; }
    }
}
