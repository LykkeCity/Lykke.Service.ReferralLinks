// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Newtonsoft.Json;

namespace Lykke.Service.BitcoinApi.Client.Models
{
    public partial class TransactionIdResponse
    {
        /// <summary>
        /// Initializes a new instance of the TransactionIdResponse class.
        /// </summary>
        public TransactionIdResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionIdResponse class.
        /// </summary>
        public TransactionIdResponse(System.Guid? transactionId = default(System.Guid?))
        {
            TransactionId = transactionId;
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

    }
}
