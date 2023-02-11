using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GrupoBoticario.Models
{
    public class RepositoryDetailModel
    {
        [JsonPropertyName("node_id")]
        public string repositoryId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("private")]
        public bool isPrivate { get; set; }

        [JsonPropertyName("stargazers_count")]
        public int stargazersCount { get; set; }

        [DisplayName("Linguagem")]
        [Display(Name = "Linguagem")]
        [JsonPropertyName("language")]
        public string language { get; set; }

        public int page { get; set; }

        [JsonPropertyName("items")]
        public List<RepositoryDetailModel> repositoryItem { get; set; }

        [Display(Name = "Nome")]
        [DisplayName("Nome")]
        [JsonPropertyName("full_name")]
        public string fullName { get; set; }

        [JsonPropertyName("html_url")]
        public string htmlUrl { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }
    }

}
