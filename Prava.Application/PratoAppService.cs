using System.Collections.Generic;
using Prova.Application.Interface;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces.Services;

namespace Prova.Application
{
    public class PratoAppService : AppServiceBase<Prato>, IPratoAppService
    {
        private readonly IPratoService _pratoService;

        public PratoAppService(IPratoService pratoService)
            : base(pratoService)
        {
            _pratoService = pratoService;
        }

        
        public IEnumerable<Prato> BuscarPratoPorNome(string nome)
        {
            return _pratoService.BuscarPratoPorNome(nome);
        }
    }
}