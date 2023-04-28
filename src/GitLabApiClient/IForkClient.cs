using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Fork.Requests;
using GitLabApiClient.Models.Fork.Responses;
using GitLabApiClient.Models.Projects.Responses;

namespace GitLabApiClient
{
    public interface IForkClient
    {

        /// <summary>
        /// Creates a fork
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="request">Create fork request</param>
        /// <returns></returns>
        Task<Fork> CreateAsync(ProjectId projectId, CreateForkRequest request);

    }
}
