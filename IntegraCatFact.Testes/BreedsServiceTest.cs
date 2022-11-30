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
        private readonly Mock<IMapper> _mapperMock = new();
        private readonly Mock<ICatFactApi> _catFactApiMock = new();

        //private readonly IBreedsService _breedsService;

        //public BreedsServiceTest()
        //{
        //    var service = new ServiceCollection();
        //    service.AddTransient<IBreedsService, BreedsService>();

        //    var provider = service.BuildServiceProvider();
        //    _breedsService = provider.GetService<IBreedsService>();
        //}

        [TestMethod]
        public void Post_Test_OK()
        {
            var _breedsService = new BreedsService(_mapperMock.Object, _catFactApiMock.Object);

            var responseAPI = _breedsService.BuscarBreeds(10, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            Assert.IsInstanceOfType(responseAPI.Result, typeof(OkResult));
        }

    }
}
