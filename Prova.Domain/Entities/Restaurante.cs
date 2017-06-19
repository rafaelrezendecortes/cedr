using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Domain.Entities
{
    public class Restaurante
    {
        public int RestauranteId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Prato> PratoLista { get; set; }


    }
}
