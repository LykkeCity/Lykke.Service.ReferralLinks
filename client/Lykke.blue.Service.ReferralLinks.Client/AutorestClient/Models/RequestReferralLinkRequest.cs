// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RequestReferralLinkRequest
    {
        /// <summary>
        /// Initializes a new instance of the RequestReferralLinkRequest class.
        /// </summary>
        public RequestReferralLinkRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestReferralLinkRequest class.
        /// </summary>
        public RequestReferralLinkRequest(double amount, string senderClientId = default(string), string asset = default(string))
        {
            SenderClientId = senderClientId;
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
        [JsonProperty(PropertyName = "SenderClientId")]
        public string SenderClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

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
