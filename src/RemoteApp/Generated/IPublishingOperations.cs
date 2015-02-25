// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RemoteApp.Models;

namespace Microsoft.Azure.Management.RemoteApp
{
    /// <summary>
    /// Operations related to publishing.
    /// </summary>
    public partial interface IPublishingOperations
    {
        /// <summary>
        /// Gets the details of a published application with given alias (short
        /// unique name) from the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='alias'>
        /// Alias of published application
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplication operation.
        /// </returns>
        Task<GetPublishedApplicationResult> GetAsync(string collectionName, string alias, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of details for all published applications from the
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplicationList operation.
        /// </returns>
        Task<GetPublishedApplicationListResult> ListAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets a published application matching the given alias (short unique
        /// name) in the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='alias'>
        /// Alias of published application
        /// </param>
        /// <param name='applicationDetails'>
        /// New details for the application
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of ModifyApplicaton operation.
        /// </returns>
        Task<ModifyApplicationResult> ModifyApplicationAsync(string collectionName, string alias, ApplicationDetailsParameter applicationDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Publishes remote applications with given application details in the
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='applicationDetailsList'>
        /// List of publishing details
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of PublishApplications operation.
        /// </returns>
        Task<PublishApplicationsResult> PublishApplicationsAsync(string collectionName, ApplicationDetailsListParameter applicationDetailsList, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a start menu application details for the given id from the
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='applicationId'>
        /// Start menu application Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplication operation.
        /// </returns>
        Task<GetStartMenuApplicationResult> StartMenuApplicationAsync(string collectionName, string applicationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of all start menu applications from the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplicationList operation.
        /// </returns>
        Task<GetStartMenuApplicationListResult> StartMenuApplicationListAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unpublishes published applications matching the given list of
        /// application aliases (short unique names) from the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='aliasesList'>
        /// List of application aliases to be unpublished
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        Task<UnpublishApplicationsResult> UnpublishAsync(string collectionName, AliasesListParameter aliasesList, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unpublishes all published applications from the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Collection Name
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        Task<UnpublishApplicationsResult> UnpublishAllAsync(string collectionName, CancellationToken cancellationToken);
    }
}
