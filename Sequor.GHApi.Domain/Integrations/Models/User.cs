using Newtonsoft.Json;

namespace Sequor.GHApi.Domain.Integrations.Models
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("node_id")]
        public string NodeId { get; set; }
        [JsonProperty("repos_url")]
        public string reposUrl { get; set; }
    }
}
