using System.Dynamic;
using System.Text.Json;
using IntegraCatFact.Aplicacao.DTOs;
using IntegraCatFact.Aplicacao.Interfaces;
using IntegraCatFact.Dominio.Models;

namespace IntegraCatfact.Aplicacao.Rest
{
    public class CatFactApiRest : ICatFactApi
    {
        
        public async Task<ResponseGenerico<BreedsModel>> BuscarBreeds(int? limite)
        {
            var ennPoint = !limite.HasValue ? "https://catfact.ninja/breeds/" : $"https://catfact.ninja/breeds?limit={limite}";

            var request = new HttpRequestMessage(HttpMethod.Get, ennPoint);

            var response = new ResponseGenerico<BreedsModel>();

            using (var client = new HttpClient())
            {
                var responseCatfactApi = await client.SendAsync(request);
                var contentResp = await responseCatfactApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BreedsModel>(contentResp);

                if (responseCatfactApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseCatfactApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseCatfactApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }
    }
}
