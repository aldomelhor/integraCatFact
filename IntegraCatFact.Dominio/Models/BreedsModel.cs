using System.Text.Json.Serialization;

namespace IntegraCatFact.Dominio.Models
{
    public class BreedsModel
    {
        [JsonPropertyName("data")]
        public List<DataModelo>? dados { get; set; }
    }

    public class DataModelo
    {
        [JsonPropertyName("breed")]
        public string? Raca { get; set; }

        [JsonPropertyName("country")]
        public string? Pais { get; set; }

        [JsonPropertyName("origin")]
        public string? Origem { get; set; }

        [JsonPropertyName("coat")]
        public string? Casaco { get; set; }

        [JsonPropertyName("pattern")]
        public string? Padrao { get; set; }
    }
}

