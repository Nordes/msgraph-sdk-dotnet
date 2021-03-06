// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsHlookupRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsHlookupRequestBody
    {
    
        /// <summary>
        /// Gets or sets LookupValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lookupValue", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken LookupValue { get; set; }
    
        /// <summary>
        /// Gets or sets TableArray.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tableArray", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken TableArray { get; set; }
    
        /// <summary>
        /// Gets or sets RowIndexNum.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowIndexNum", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken RowIndexNum { get; set; }
    
        /// <summary>
        /// Gets or sets RangeLookup.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rangeLookup", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken RangeLookup { get; set; }
    
    }
}
