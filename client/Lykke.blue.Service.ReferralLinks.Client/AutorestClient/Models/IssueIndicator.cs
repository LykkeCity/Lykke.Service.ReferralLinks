﻿// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
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

    public partial class IssueIndicator
    {
        /// <summary>
        /// Initializes a new instance of the IssueIndicator class.
        /// </summary>
        public IssueIndicator()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssueIndicator class.
        /// </summary>
        public IssueIndicator(string type = default(string), string value = default(string))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
