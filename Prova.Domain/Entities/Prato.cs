using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Domain.Entities
{
    public class Prato
    {
        public int PratoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        //public virtual IEnumerable<Restaurante> Restaurante { get; set; }

        public virtual int RestauranteId { get; set; }
        public virtual Restaurante Restaurante { get; set; }

        //public virtual ICollection<Restaurante> RestauranteLista { get; set; }


    }
}
