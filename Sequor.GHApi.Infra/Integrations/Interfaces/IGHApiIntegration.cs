﻿using Sequor.GHApi.Domain.Integrations.Models;

namespace Sequor.GHApi.Infra.Integrations.Interfaces
{
    public interface IGHApiIntegration
    {
        Task<List<User>> GetUserList();
        Task<List<Repo>> GetRepoListByLogin(string login);
    }
}
