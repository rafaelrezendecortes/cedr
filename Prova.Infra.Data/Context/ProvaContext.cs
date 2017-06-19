using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using Prova.Domain.Entities;
using Prova.Infra.Data.EntityConfig;

namespace Prova.Infra.Data.Context
{
    public class ProvaContext : DbContext
    {

        public ProvaContext()
            : base("provaConnectionString")
        {
            //construtor herdando a base e como paramentro string de conexão;
        }

        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Quando criar tabela ele não pluraliza os nomes de tabelas.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Não quero que ele delete em cascata em uma relação de um para muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Não quero que ele delete em cascata em uma relação de de muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //defino que se uma propriedade tiver no nome o campo Id ela é chave primaria.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //    .Configure(p => p.HasMaxLength(11));

            //Tudo que for string será um varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Tudo que for string será por padrão tamanho 1000
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(1000));


            //Seta qual é a configuração especifica para cada um
            modelBuilder.Configurations.Add(new PratoConfiguration());
            modelBuilder.Configurations.Add(new RestauranteConfiguration());
            
        }


    }
}
