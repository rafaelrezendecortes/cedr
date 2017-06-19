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
    public class PratoService : ServiceBase<Prato>, IPratoService
    {

        private readonly IPratoRepository _pratoRepository;

        public PratoService(IPratoRepository pratoRepository)
            : base(pratoRepository)
        {
            _pratoRepository = pratoRepository;
        }


        public IEnumerable<Prato> BuscarPratoPorNome(string nome)
        {
            return _pratoRepository.BuscarPratoPorNome(nome);
        }


    }
}
