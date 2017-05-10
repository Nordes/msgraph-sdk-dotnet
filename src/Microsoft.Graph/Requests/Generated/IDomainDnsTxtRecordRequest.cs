// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDomainDnsTxtRecordRequest.
    /// </summary>
    public partial interface IDomainDnsTxtRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsTxtRecord using PUT.
        /// </summary>
        /// <param name="domainDnsTxtRecordToCreate">The DomainDnsTxtRecord to create.</param>
        /// <returns>The created DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> CreateAsync(DomainDnsTxtRecord domainDnsTxtRecordToCreate);        /// <summary>
        /// Creates the specified DomainDnsTxtRecord using PUT.
        /// </summary>
        /// <param name="domainDnsTxtRecordToCreate">The DomainDnsTxtRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> CreateAsync(DomainDnsTxtRecord domainDnsTxtRecordToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DomainDnsTxtRecord.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DomainDnsTxtRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DomainDnsTxtRecord.
        /// </summary>
        /// <returns>The DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> GetAsync();

        /// <summary>
        /// Gets the specified DomainDnsTxtRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DomainDnsTxtRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsTxtRecordToUpdate">The DomainDnsTxtRecord to update.</param>
        /// <returns>The updated DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> UpdateAsync(DomainDnsTxtRecord domainDnsTxtRecordToUpdate);

        /// <summary>
        /// Updates the specified DomainDnsTxtRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsTxtRecordToUpdate">The DomainDnsTxtRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DomainDnsTxtRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsTxtRecord> UpdateAsync(DomainDnsTxtRecord domainDnsTxtRecordToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsTxtRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsTxtRecordRequest Expand(Expression<Func<DomainDnsTxtRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsTxtRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsTxtRecordRequest Select(Expression<Func<DomainDnsTxtRecord, object>> selectExpression);

    }
}