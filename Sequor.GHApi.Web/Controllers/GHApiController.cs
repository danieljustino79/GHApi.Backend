using Microsoft.AspNetCore.Mvc;
using Sequor.GHApi.Application.Services.Interfaces;

namespace Sequor.GHApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GHApiController : ControllerBase
    {
        private IGHApiService _ghapiService;
        public GHApiController(IGHApiService githubapiService)
        {
            _ghapiService = githubapiService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var users = _ghapiService.GetUserList();
            if (users.Result.Count > 0)
            {
                return Ok(users.Result);
            }

            return BadRequest("erro");
        }

        [HttpGet("RepoListByLogin")]
        public ActionResult Get(string login)
        {
            var repos = _ghapiService.GetRepoListByLogin(login);
            if (repos.Result.Count > 0)
            {
                return Ok(repos.Result);
            }

            return NotFound("erro");
        }
    }
}
