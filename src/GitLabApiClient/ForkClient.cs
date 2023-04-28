using System;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Fork.Requests;
using GitLabApiClient.Models.Fork.Responses;

namespace GitLabApiClient
{
    public sealed class ForkClient : IForkClient
    {
        private readonly GitLabHttpFacade _httpFacade;

        internal ForkClient(GitLabHttpFacade httpFacade) => _httpFacade = httpFacade;


        public async Task<Fork> CreateAsync(ProjectId projectId, CreateForkRequest request)
        {
            var res = await _httpFacade.Post<Fork>($"projects/{projectId}/fork", request);

            return res;
        }

    }
}


