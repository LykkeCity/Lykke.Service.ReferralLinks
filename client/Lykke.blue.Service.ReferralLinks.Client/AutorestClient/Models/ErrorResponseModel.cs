// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.blue.Service.ReferralLinks.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
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
        public ErrorResponseModel(string errorMessage = default(string))
        {
            ErrorMessage = errorMessage;
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

    }
}
