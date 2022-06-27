using Sequor.GHApi.Domain.Integrations.Models;

namespace Sequor.GHApi.Application.Services.Interfaces
{
    public interface IGHApiService
    {
        Task<List<User>> GetUserList();
        Task<List<Repo>> GetRepoListByLogin(string login);
    }
}
