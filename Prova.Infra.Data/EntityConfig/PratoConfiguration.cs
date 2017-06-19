using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Prova.Domain.Entities;

namespace Prova.Infra.Data.EntityConfig
{
    public class PratoConfiguration : EntityTypeConfiguration<Prato>
    {
        public PratoConfiguration()
        {
            HasKey(c => c.PratoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Valor)
                .IsRequired();


            HasRequired(c => c.Restaurante)
             .WithMany(p => p.PratoLista).HasForeignKey(p => p.RestauranteId);

        }
    }
}
