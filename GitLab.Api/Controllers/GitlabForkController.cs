using System.Reflection;
using GitLabApiClient;
using GitLabApiClient.Internal.Paths;
using Microsoft.AspNetCore.Mvc;

namespace GitLab.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitlabForkController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<GitlabForkController> _logger;

        public GitlabForkController(ILogger<GitlabForkController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var adminClient = new GitLabClient("http://10.255.134.203:8081/", "glpat-PRVXVfx9YFm_4vB9ZKej");
            var userRes = await adminClient.Users.CreateAsync(new GitLabApiClient.Models.Users.Requests.CreateUserRequest("亮工", "liangu", "470789309@qq.com") { Password = "qwert123456", SkipConfirmation = true, ResetPassword = false, ForceRandomPassword = false });


            var client = new GitLabClient("http://10.255.134.203:8081/");
            var res = await client.LoginAsync("liangu", "qwert123456");

            var groupRes = await client.Groups.CreateAsync(new GitLabApiClient.Models.Groups.Requests.CreateGroupRequest("demo", "demo"));

            ProjectId sut = "5";
            var forkRes = await client.ForkClient.CreateAsync(sut, new GitLabApiClient.Models.Fork.Requests.CreateForkRequest("demo", "", ""));

            return "";
        }
    }
}
