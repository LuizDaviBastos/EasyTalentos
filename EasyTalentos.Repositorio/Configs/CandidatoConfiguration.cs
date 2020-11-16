using EasyTalentos.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyTalentos.Repositorio.Configs
{
    public class CandidatoConfiguration : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Telefone).IsRequired();
            builder.Property(c => c.Cidade).IsRequired();
            builder.Property(c => c.Estado).IsRequired();
            builder.Property(c => c.PretencaoSalario).IsRequired();



            //Relacionamentos
            builder.HasOne(c => c.Conhecimento)
                .WithOne(c => c.Candidato)
                .HasForeignKey<Conhecimento>(c => c.CandidatoId);

            builder.HasOne(c => c.Disponibilidade)
                .WithOne(c => c.Candidato)
                .HasForeignKey<Disponibilidade>(d => d.CandidatoId);

            builder.HasOne(c => c.Preferencia)
                .WithOne(c => c.Candidato)
                .HasForeignKey<Preferencia>(p => p.CandidatoId);

        }
    }
}
