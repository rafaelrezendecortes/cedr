using System.Collections.Generic;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces.Repositories;
using System.Linq;

namespace Prova.Infra.Data.Repositorio
{
    public class PratoRepository : RepositoryBase<Prato>, IPratoRepository
    {
        public IEnumerable<Prato> BuscarPratoPorNome(string nome)
        {
            return Db.Pratos.Where(p => p.Nome.Contains(nome)).ToList();
        }
    }
}