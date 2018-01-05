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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GiftCoinRequestGroup
    {
        /// <summary>
        /// Initializes a new instance of the GiftCoinRequestGroup class.
        /// </summary>
        public GiftCoinRequestGroup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GiftCoinRequestGroup class.
        /// </summary>
        public GiftCoinRequestGroup(IList<double?> amountForEachLink = default(IList<double?>), string senderClientId = default(string), string asset = default(string))
        {
            AmountForEachLink = amountForEachLink;
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
        [JsonProperty(PropertyName = "AmountForEachLink")]
        public IList<double?> AmountForEachLink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SenderClientId")]
        public string SenderClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Asset")]
        public string Asset { get; set; }

    }
}
