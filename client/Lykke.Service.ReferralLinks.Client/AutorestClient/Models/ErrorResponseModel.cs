// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ReferralLinks.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ErrorResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseModel class.
        /// </summary>
        public ErrorResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseModel class.
        /// </summary>
        public ErrorResponseModel(string errorMessage = default(string), IDictionary<string, IList<string>> modelErrors = default(IDictionary<string, IList<string>>))
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