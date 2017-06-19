using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using Prova.Domain.Entities;

namespace Prova.Infra.Data.EntityConfig
{
    public class RestauranteConfiguration : EntityTypeConfiguration<Restaurante>
    {
        public RestauranteConfiguration()
        {
            HasKey(p => p.RestauranteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);

                       

        }
    }
}
