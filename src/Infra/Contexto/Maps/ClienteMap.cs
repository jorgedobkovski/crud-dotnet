using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(60)");
            builder.Property(c => c.CPF).HasColumnType("varchar(15)");
            builder.Property(c => c.RG).IsRequired().HasColumnType("varchar(15)");
            builder.Property(c => c.DataNascimento).IsRequired().HasColumnType("date");
        }
    }
}
