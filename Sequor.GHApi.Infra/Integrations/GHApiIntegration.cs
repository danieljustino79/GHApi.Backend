using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Sequor.GHApi.Domain.Integrations.Models;
using Sequor.GHApi.Infra.Integrations.Interfaces;

namespace Sequor.GHApi.Infra.Integrations
{
    public  class GHApiIntegration : IGHApiIntegration
    {
        private readonly IConfiguration _configuration;

        public GHApiIntegration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<User>> GetUserList()
        {
            using var client = new HttpClient();

            var urlBase = _configuration["GithubApi:UrlBase"];
            var accessToken = _configuration["GithubApi:AuthorizationPat"];

            client.DefaultRequestHeaders.Add("User-Agent", "request");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            HttpResponseMessage response = await client.GetAsync(urlBase + "/users");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(content);
                return users;
            }

            return new List<User>();
        }

        public async Task<List<Repo>> GetRepoListByLogin(string login)
        {
            using var client = new HttpClient();

            var urlBase = _configuration["GithubApi:UrlBase"];
            var accessToken = _configuration["GithubApi:AuthorizationPat"];

            client.DefaultRequestHeaders.Add("User-Agent", "request");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            HttpResponseMessage response = await client.GetAsync($"{urlBase}/users/{login}/repos");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var repos = JsonConvert.DeserializeObject<List<Repo>>(content);
                return repos;
            }

            return new List<Repo>();
        }
    }
}
