using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Fork.Requests
{
    /// <summary>
    /// Creates a new fork on a project.
    /// </summary>
    public sealed class CreateForkRequest
    {


        public CreateForkRequest(string groupName, string name, string path)
        {
            Guard.NotEmpty(groupName, nameof(groupName));
            GroupName = groupName;
            Name = name;
            Path = path;
        }

        /// <summary>
        /// Branch Name.
        /// </summary>
        [JsonProperty("namespace_path")]
        public string GroupName { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("path")]
        public string Path { get; set; }

    }
}
