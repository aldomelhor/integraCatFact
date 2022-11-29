using IntegraCatfact.Aplicacao.Services;
using IntegraCatFact.Aplicacao.Interfaces;
using IntegraCatFact.Servicos.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IntegraCatFact.Testes
{
    [TestClass]
    public class BreedsControllerTest
    {
        private readonly IBreedsService _breedsService;

        [TestMethod]
        [DataRow("10")]
        [DataRow("1")]
        public void Post_Test(int limite)
        {
            var breedsController = new BreedsController(_breedsService);

            var responseAPI = breedsController.BuscarBreeds(limite, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }

        [TestMethod]
        public void Post_Test_BadRequest()
        {
            var responseAPI = breedsController.BuscarBreeds(null, null, "Brasil", null, null, null);
            Assert.IsInstanceOfType(responseAPI, typeof(BadRequestResult));
        }

    }
}