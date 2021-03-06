// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Payments
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    

    /// <summary>
    /// Provides details that modify the PaymentDetails based on payment
    /// method identifier
    /// </summary>
    public partial class PaymentDetailsModifier
    {
        /// <summary>
        /// Initializes a new instance of the PaymentDetailsModifier class.
        /// </summary>
        public PaymentDetailsModifier() { }

        /// <summary>
        /// Initializes a new instance of the PaymentDetailsModifier class.
        /// </summary>
        public PaymentDetailsModifier(IList<string> supportedMethods = default(IList<string>), PaymentItem total = default(PaymentItem), IList<PaymentItem> additionalDisplayItems = default(IList<PaymentItem>), object data = default(object))
        {
            SupportedMethods = supportedMethods;
            Total = total;
            AdditionalDisplayItems = additionalDisplayItems;
            Data = data;
        }

        /// <summary>
        /// Contains a sequence of payment method identifiers
        /// </summary>
        [JsonProperty(PropertyName = "supportedMethods")]
        public IList<string> SupportedMethods { get; set; }

        /// <summary>
        /// This value overrides the total field in the PaymentDetails
        /// dictionary for the payment method identifiers in the
        /// supportedMethods field
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public PaymentItem Total { get; set; }

        /// <summary>
        /// Provides additional display items that are appended to the
        /// displayItems field in the PaymentDetails dictionary for the
        /// payment method identifiers in the supportedMethods field
        /// </summary>
        [JsonProperty(PropertyName = "additionalDisplayItems")]
        public IList<PaymentItem> AdditionalDisplayItems { get; set; }

        /// <summary>
        /// A JSON-serializable object that provides optional information that
        /// might be needed by the supported payment methods
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

    }
}
