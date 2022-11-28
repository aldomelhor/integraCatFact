namespace IntegraCatFactApi.Aplicacao.DTOs
{
    public class BreedsDtos
    {
        public List<Data>? data { get; set; }
    }

    public class Data
    {
        public string? Raca { get; set; }
        public string? Pais { get; set; }
        public string? Origem { get; set; }
        public string? Casaco { get; set; }
        public string? Padrao { get; set; }
    }
}
