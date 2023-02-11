using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GrupoBoticario.Models
{
    public class RepositoryModel
    {
        [JsonPropertyName("total_count")]
        public int totalCount { get; set; }

        [JsonPropertyName("incomplete_results")]
        public bool incompleteResults { get; set; }

        [JsonPropertyName("items")]
        public List<RepositoryDetailModel> repositoryItem { get; set; }
    }
}
