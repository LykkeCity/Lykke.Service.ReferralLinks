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

    public partial class BroadcastCommitmentModel
    {
        /// <summary>
        /// Initializes a new instance of the BroadcastCommitmentModel class.
        /// </summary>
        public BroadcastCommitmentModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BroadcastCommitmentModel class.
        /// </summary>
        public BroadcastCommitmentModel(string clientPubKey = default(string), string asset = default(string), string transaction = default(string))
        {
            ClientPubKey = clientPubKey;
            Asset = asset;
            Transaction = transaction;
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
        [JsonProperty(PropertyName = "transaction")]
        public string Transaction { get; set; }

    }
}
