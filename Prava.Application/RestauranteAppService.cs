using Prova.Application.Interface;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces.Services;

namespace Prova.Application
{
    public class RestauranteAppService : AppServiceBase<Restaurante>, IRestauranteService, IRestauranteAppService
    {
        private readonly IRestauranteService _restauranteService;

        public RestauranteAppService(IRestauranteService restauranteService) 
            : base(restauranteService)
        {
            _restauranteService = restauranteService;
        }

    }
}