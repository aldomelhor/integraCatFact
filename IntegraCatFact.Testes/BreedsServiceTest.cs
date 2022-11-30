using AutoMapper;
using IntegraCatfact.Aplicacao.Services;
using IntegraCatFact.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace IntegraCatFact.Testes
{
    [TestClass]
    public class BreedsServiceTest
    {
        private readonly BreedsService _breedsService;
        private readonly Mock<IMapper> _mapperMock = new();
        private readonly Mock<ICatFactApi> _catFactApiMock = new();

        public BreedsServiceTest()
        {
            _breedsService = new BreedsService(_mapperMock.Object, _catFactApiMock.Object);
        }

        [TestMethod]
        public void Post_Test()
        {
            var responseAPI = _breedsService.BuscarBreeds(null, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);

            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }

    }
}
