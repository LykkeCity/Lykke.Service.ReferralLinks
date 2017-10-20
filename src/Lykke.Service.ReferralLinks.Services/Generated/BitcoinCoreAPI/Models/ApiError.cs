// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.Service.BitcoinApi.Client.Models
{
    using Lykke.Service;
    using Lykke.Service.BitcoinApi;
    using Lykke.Service.BitcoinApi.Client;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiError
    {
        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        public ApiError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        /// <param name="code">Possible values include: 'Exception',
        /// 'ProblemInRetrivingWalletOutput', 'ProblemInRetrivingTransaction',
        /// 'NotEnoughBitcoinAvailable', 'NotEnoughAssetAvailable',
        /// 'PossibleDoubleSpend', 'AssetNotFound',
        /// 'TransactionNotSignedProperly', 'BadInputParameter',
        /// 'PersistantConcurrencyProblem', 'NoCoinsToRefund', 'NoCoinsFound',
        /// 'InvalidAddress', 'OperationNotSupported',
        /// 'PregeneratedPoolIsEmpty', 'TransactionConcurrentInputsProblem',
        /// 'AddressHasUncompletedSignRequest', 'ShouldOpenNewChannel',
        /// 'BadTransaction', 'BadFullSignTransaction', 'CommitmentNotFound',
        /// 'DuplicateTransactionId', 'AnotherChannelSetupExists',
        /// 'BadChannelAmount', 'ChannelNotFinalized', 'CommitmentExpired',
        /// 'KeyUsedAlready', 'NotEnoughtClientFunds', 'PrivateKeyIsBad',
        /// 'ClosingChannelNotFound', 'ClosingChannelExpired',
        /// 'DuplicateRequest', 'TransferNotFound', 'WrongTransferId',
        /// 'AddressUsedInOffchain', 'ChannelWasBroadcasted',
        /// 'AssetSettingNotFound'</param>
        public ApiError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Exception',
        /// 'ProblemInRetrivingWalletOutput', 'ProblemInRetrivingTransaction',
        /// 'NotEnoughBitcoinAvailable', 'NotEnoughAssetAvailable',
        /// 'PossibleDoubleSpend', 'AssetNotFound',
        /// 'TransactionNotSignedProperly', 'BadInputParameter',
        /// 'PersistantConcurrencyProblem', 'NoCoinsToRefund', 'NoCoinsFound',
        /// 'InvalidAddress', 'OperationNotSupported',
        /// 'PregeneratedPoolIsEmpty', 'TransactionConcurrentInputsProblem',
        /// 'AddressHasUncompletedSignRequest', 'ShouldOpenNewChannel',
        /// 'BadTransaction', 'BadFullSignTransaction', 'CommitmentNotFound',
        /// 'DuplicateTransactionId', 'AnotherChannelSetupExists',
        /// 'BadChannelAmount', 'ChannelNotFinalized', 'CommitmentExpired',
        /// 'KeyUsedAlready', 'NotEnoughtClientFunds', 'PrivateKeyIsBad',
        /// 'ClosingChannelNotFound', 'ClosingChannelExpired',
        /// 'DuplicateRequest', 'TransferNotFound', 'WrongTransferId',
        /// 'AddressUsedInOffchain', 'ChannelWasBroadcasted',
        /// 'AssetSettingNotFound'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
