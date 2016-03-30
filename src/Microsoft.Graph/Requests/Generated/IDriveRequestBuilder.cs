// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDriveRequestBuilder.
    /// </summary>
    public partial interface IDriveRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDriveRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDriveRequest Request(IEnumerable<Option> options);
        
        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IDriveItemsCollectionRequestBuilder"/>.</returns>
        IDriveItemsCollectionRequestBuilder Items { get; }

        /// <summary>
        /// Gets the request builder for Special.
        /// </summary>
        /// <returns>The <see cref="IDriveSpecialCollectionRequestBuilder"/>.</returns>
        IDriveSpecialCollectionRequestBuilder Special { get; }

        /// <summary>
        /// Gets the request builder for Root.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        IDriveItemRequestBuilder Root { get; }
        
        /// <summary>
        /// Gets the request builder for DriveRecent.
        /// </summary>
        /// <returns>The <see cref="IDriveRecentRequestBuilder"/>.</returns>
        IDriveRecentRequestBuilder Recent();

        /// <summary>
        /// Gets the request builder for DriveSharedWithMe.
        /// </summary>
        /// <returns>The <see cref="IDriveSharedWithMeRequestBuilder"/>.</returns>
        IDriveSharedWithMeRequestBuilder SharedWithMe();
    
    }
}