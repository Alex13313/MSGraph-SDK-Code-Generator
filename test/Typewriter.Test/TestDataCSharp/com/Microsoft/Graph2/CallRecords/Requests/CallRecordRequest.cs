// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type CallRecordRequest.
    /// </summary>
    public partial class CallRecordRequest : Microsoft.Graph.BaseRequest, ICallRecordRequest
    {
        /// <summary>
        /// Constructs a new CallRecordRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CallRecordRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CallRecord using POST.
        /// </summary>
        /// <param name="callRecordToCreate">The CallRecord to create.</param>
        /// <returns>The created CallRecord.</returns>
        public System.Threading.Tasks.Task<CallRecord> CreateAsync(CallRecord callRecordToCreate)
        {
            return this.CreateAsync(callRecordToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified CallRecord using POST.
        /// </summary>
        /// <param name="callRecordToCreate">The CallRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CallRecord.</returns>
        public async System.Threading.Tasks.Task<CallRecord> CreateAsync(CallRecord callRecordToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<CallRecord>(callRecordToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified CallRecord.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified CallRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<CallRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified CallRecord.
        /// </summary>
        /// <returns>The CallRecord.</returns>
        public System.Threading.Tasks.Task<CallRecord> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CallRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CallRecord.</returns>
        public async System.Threading.Tasks.Task<CallRecord> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<CallRecord>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified CallRecord using PATCH.
        /// </summary>
        /// <param name="callRecordToUpdate">The CallRecord to update.</param>
        /// <returns>The updated CallRecord.</returns>
        public System.Threading.Tasks.Task<CallRecord> UpdateAsync(CallRecord callRecordToUpdate)
        {
            return this.UpdateAsync(callRecordToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified CallRecord using PATCH.
        /// </summary>
        /// <param name="callRecordToUpdate">The CallRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CallRecord.</returns>
        public async System.Threading.Tasks.Task<CallRecord> UpdateAsync(CallRecord callRecordToUpdate, CancellationToken cancellationToken)
        {
			if (callRecordToUpdate.AdditionalData != null)
			{
				if (callRecordToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					callRecordToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, callRecordToUpdate.GetType().Name)
						});
				}
			}
            if (callRecordToUpdate.AdditionalData != null)
            {
                if (callRecordToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    callRecordToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, callRecordToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<CallRecord>(callRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordRequest Expand(Expression<Func<CallRecord, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordRequest Select(Expression<Func<CallRecord, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="callRecordToInitialize">The <see cref="CallRecord"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CallRecord callRecordToInitialize)
        {

            if (callRecordToInitialize != null && callRecordToInitialize.AdditionalData != null)
            {

                if (callRecordToInitialize.Sessions != null && callRecordToInitialize.Sessions.CurrentPage != null)
                {
                    callRecordToInitialize.Sessions.AdditionalData = callRecordToInitialize.AdditionalData;

                    object nextPageLink;
                    callRecordToInitialize.AdditionalData.TryGetValue("sessions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        callRecordToInitialize.Sessions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (callRecordToInitialize.Recipients != null && callRecordToInitialize.Recipients.CurrentPage != null)
                {
                    callRecordToInitialize.Recipients.AdditionalData = callRecordToInitialize.AdditionalData;

                    object nextPageLink;
                    callRecordToInitialize.AdditionalData.TryGetValue("recipients@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        callRecordToInitialize.Recipients.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
