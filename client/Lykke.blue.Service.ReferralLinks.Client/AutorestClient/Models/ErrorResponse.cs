﻿// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse(string errorMessage = default(string), IDictionary<string, IList<string>> modelErrors = default(IDictionary<string, IList<string>>))
        {
            ErrorMessage = errorMessage;
            ModelErrors = modelErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModelErrors")]
        public IDictionary<string, IList<string>> ModelErrors { get; private set; }

    }
}
