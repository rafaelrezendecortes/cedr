using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces;
using Prova.Domain.Interfaces.Services;

namespace Prova.Domain.Interfaces.Repositories
{
    public interface IPratoRepository : IRepositoryBase<Prato>
    {
        IEnumerable<Prato> BuscarPratoPorNome(string nome);
    }
}
