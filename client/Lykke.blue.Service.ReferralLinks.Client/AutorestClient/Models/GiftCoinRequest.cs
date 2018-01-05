// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient.Models
{
    using Lykke.blue;
    using Lykke.blue.Service;
    using Lykke.blue.Service.ReferralLinks;
    using Lykke.blue.Service.ReferralLinks.Client;
    using Lykke.blue.Service.ReferralLinks.Client.AutorestClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GiftCoinRequest
    {
        /// <summary>
        /// Initializes a new instance of the GiftCoinRequest class.
        /// </summary>
        public GiftCoinRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GiftCoinRequest class.
        /// </summary>
        public GiftCoinRequest(double amount, string senderClientId = default(string), string asset = default(string))
        {
            Amount = amount;
            SenderClientId = senderClientId;
            Asset = asset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SenderClientId")]
        public string SenderClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Asset")]
        public string Asset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}