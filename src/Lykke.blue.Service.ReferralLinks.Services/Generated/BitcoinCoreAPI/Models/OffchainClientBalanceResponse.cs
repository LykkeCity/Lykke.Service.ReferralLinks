// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Newtonsoft.Json;

namespace Lykke.Service.BitcoinApi.Client.Models
{
    public partial class OffchainClientBalanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the OffchainClientBalanceResponse
        /// class.
        /// </summary>
        public OffchainClientBalanceResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OffchainClientBalanceResponse
        /// class.
        /// </summary>
        public OffchainClientBalanceResponse(decimal? amount = default(decimal?))
        {
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount { get; set; }

    }
}
