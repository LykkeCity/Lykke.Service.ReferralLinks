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

    public partial class FinalizeOffchainApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the FinalizeOffchainApiResponse
        /// class.
        /// </summary>
        public FinalizeOffchainApiResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FinalizeOffchainApiResponse
        /// class.
        /// </summary>
        public FinalizeOffchainApiResponse(string hash = default(string), string transaction = default(string), System.Guid? transferId = default(System.Guid?))
        {
            Hash = hash;
            Transaction = transaction;
            TransferId = transferId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transferId")]
        public System.Guid? TransferId { get; set; }

    }
}
