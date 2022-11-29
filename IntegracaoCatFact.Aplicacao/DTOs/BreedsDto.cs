namespace IntegraCatFact.Aplicacao.DTOs
{
    public class BreedsDto
    {
        public List<DataDto>? dados { get; set; }
    }

    public class DataDto
    {
        public string? Raca { get; set; }
        public string? Pais { get; set; }
        public string? Origem { get; set; }
        public string? Casaco { get; set; }
        public string? Padrao { get; set; }
    }
}
