using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces;
using Prova.Domain.Interfaces.Services;
using Prova.Domain.Interfaces.Repositories;

namespace Prova.Domain.Services
{
    public class RestauranteService : ServiceBase<Restaurante>, IRestauranteService
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteService(IRestauranteRepository restauranteRepository) : base(restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }
               

    }
}
