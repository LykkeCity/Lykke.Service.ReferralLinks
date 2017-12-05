// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Newtonsoft.Json;

namespace Lykke.Service.BitcoinApi.Client.Models
{
    public partial class FinalizeChannelModel
    {
        /// <summary>
        /// Initializes a new instance of the FinalizeChannelModel class.
        /// </summary>
        public FinalizeChannelModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FinalizeChannelModel class.
        /// </summary>
        public FinalizeChannelModel(string clientPubKey = default(string), string asset = default(string), string clientRevokePubKey = default(string), string signedByClientHubCommitment = default(string), System.Guid? transferId = default(System.Guid?), System.Guid? notifyTxId = default(System.Guid?))
        {
            ClientPubKey = clientPubKey;
            Asset = asset;
            ClientRevokePubKey = clientRevokePubKey;
            SignedByClientHubCommitment = signedByClientHubCommitment;
            TransferId = transferId;
            NotifyTxId = notifyTxId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientPubKey")]
        public string ClientPubKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientRevokePubKey")]
        public string ClientRevokePubKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signedByClientHubCommitment")]
        public string SignedByClientHubCommitment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transferId")]
        public System.Guid? TransferId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifyTxId")]
        public System.Guid? NotifyTxId { get; set; }

    }
}
