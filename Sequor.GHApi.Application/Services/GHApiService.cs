using Sequor.GHApi.Application.Services.Interfaces;
using Sequor.GHApi.Domain.Integrations.Models;
using Sequor.GHApi.Infra.Integrations.Interfaces;

namespace Sequor.GHApi.Application.Services
{
    public class GHApiService : IGHApiService
    {
        private IGHApiIntegration _githubapiIntegration;
        public GHApiService(IGHApiIntegration githubapiIntegration)
        {
            _githubapiIntegration = githubapiIntegration;
        }

        public Task<List<User>> GetUserList() =>
            _githubapiIntegration.GetUserList();

        public async Task<List<Repo>> GetRepoListByLogin(string login)
        {
            var list = await _githubapiIntegration.GetRepoListByLogin(login);
            return list.OrderByDescending(r => r.StargazersCount).ToList();
        }
            
    }
}
