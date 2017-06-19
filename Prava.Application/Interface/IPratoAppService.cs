using System.Collections.Generic;
using Prova.Domain.Entities;

namespace Prova.Application.Interface
{
    public interface IPratoAppService : IAppServiceBase<Prato>
    {
        IEnumerable<Prato> BuscarPratoPorNome(string nome);
    }
}