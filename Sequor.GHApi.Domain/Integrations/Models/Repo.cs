using Newtonsoft.Json;

namespace Sequor.GHApi.Domain.Integrations.Models
{
    public class Repo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("private")]
        public bool Private { get; set; }
        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }
    }
}
