using System.Text.Json.Serialization;

namespace IntegraCatFactApi.Dominio.Models
{

    public class BreedsModel
    {
        public List<Data>? data { get; set; }
    }

    public class Data
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
        public string? PadraO { get; set; }
    }
}

