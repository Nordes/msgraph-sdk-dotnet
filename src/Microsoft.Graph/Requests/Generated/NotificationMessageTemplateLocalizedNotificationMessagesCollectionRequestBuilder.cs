// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder.
    /// </summary>
    public partial class NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder : BaseRequestBuilder, INotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public INotificationMessageTemplateLocalizedNotificationMessagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public INotificationMessageTemplateLocalizedNotificationMessagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILocalizedNotificationMessageRequestBuilder"/> for the specified NotificationMessageTemplateLocalizedNotificationMessage.
        /// </summary>
        /// <param name="id">The ID for the NotificationMessageTemplateLocalizedNotificationMessage.</param>
        /// <returns>The <see cref="ILocalizedNotificationMessageRequestBuilder"/>.</returns>
        public ILocalizedNotificationMessageRequestBuilder this[string id]
        {
            get
            {
                return new LocalizedNotificationMessageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}