// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Newtonsoft.Json;

namespace Lykke.Service.BitcoinApi.Client.Models
{
    public partial class DestroyRequest
    {
        /// <summary>
        /// Initializes a new instance of the DestroyRequest class.
        /// </summary>
        public DestroyRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestroyRequest class.
        /// </summary>
        public DestroyRequest(System.Guid? transactionId = default(System.Guid?), string address = default(string), string asset = default(string), decimal? amount = default(decimal?))
        {
            TransactionId = transactionId;
            Address = address;
            Asset = asset;
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionId")]
        public System.Guid? TransactionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount { get; set; }

    }
}
