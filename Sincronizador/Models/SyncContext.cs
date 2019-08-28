using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sincronizador.Models
{
    public partial class SyncContext : DbContext
    {
        public SyncContext()
        {
        }

        public SyncContext(DbContextOptions<SyncContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abierta> Abierta { get; set; }
        public virtual DbSet<Alta> Alta { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Establecimiento> Establecimiento { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Query> Query { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Unidad> Unidad { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Sync;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Abierta>(entity =>
            {
                entity.Property(e => e.CdEstabelecimento)
                    .HasColumnName("CD_ESTABELECIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.CdMedico)
                    .HasColumnName("CD_MEDICO")
                    .HasMaxLength(150);

                entity.Property(e => e.CdPaciente)
                    .HasColumnName("CD_PACIENTE")
                    .HasMaxLength(150);

                entity.Property(e => e.CdSetorAtendimento)
                    .HasColumnName("CD_SETOR_ATENDIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.CdUnidadeBasica)
                    .HasColumnName("CD_UNIDADE_BASICA")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DtActualizacion)
                    .HasColumnName("DT_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAlta)
                    .HasColumnName("DT_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEntrada)
                    .HasColumnName("DT_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NrAtendimento)
                    .HasColumnName("NR_ATENDIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Alta>(entity =>
            {
                entity.Property(e => e.CdEstabelecimento)
                    .HasColumnName("CD_ESTABELECIMENTO")
                    .HasMaxLength(50);

                entity.Property(e => e.CdMedico)
                    .HasColumnName("CD_MEDICO")
                    .HasMaxLength(50);

                entity.Property(e => e.CdPaciente)
                    .HasColumnName("CD_PACIENTE")
                    .HasMaxLength(50);

                entity.Property(e => e.CdSetorAtendimento)
                    .HasColumnName("CD_SETOR_ATENDIMENTO")
                    .HasMaxLength(50);

                entity.Property(e => e.CdUnidadeBasica)
                    .HasColumnName("CD_UNIDADE_BASICA")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DtActualizacion)
                    .HasColumnName("DT_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAlta)
                    .HasColumnName("DT_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEntrada)
                    .HasColumnName("DT_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NrAtendimento)
                    .HasColumnName("NR_ATENDIMENTO")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.Property(e => e.Ninterval).HasColumnName("NInterval");

                entity.Property(e => e.NminAbiertas).HasColumnName("NMinAbiertas");

                entity.Property(e => e.NminCat).HasColumnName("NMinCat");
            });

            modelBuilder.Entity<Establecimiento>(entity =>
            {
                entity.Property(e => e.CdEstabelecimento)
                    .HasColumnName("CD_ESTABELECIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.IeAreaEstab)
                    .HasColumnName("IE_AREA_ESTAB")
                    .HasMaxLength(150);

                entity.Property(e => e.IeTipoCtbEstab)
                    .HasColumnName("IE_TIPO_CTB_ESTAB")
                    .HasMaxLength(150);

                entity.Property(e => e.NmFantasiaEstab)
                    .HasColumnName("NM_FANTASIA_ESTAB")
                    .HasMaxLength(150);

                entity.Property(e => e.NmSiglaEstab)
                    .HasColumnName("NM_SIGLA_ESTAB")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.Property(e => e.CdCurp)
                    .HasColumnName("CD_CURP")
                    .HasMaxLength(100);

                entity.Property(e => e.CdPessoaFisica)
                    .HasColumnName("CD_PESSOA_FISICA")
                    .HasMaxLength(100);

                entity.Property(e => e.CdRfc)
                    .HasColumnName("CD_RFC")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("DT_NASCIMENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IeSexo)
                    .HasColumnName("IE_SEXO")
                    .HasMaxLength(100);

                entity.Property(e => e.NmAbreviado)
                    .HasColumnName("NM_ABREVIADO")
                    .HasMaxLength(100);

                entity.Property(e => e.NmPessoaFisica)
                    .HasColumnName("NM_PESSOA_FISICA")
                    .HasMaxLength(100);

                entity.Property(e => e.NmPrimeiroNome)
                    .HasColumnName("NM_PRIMEIRO_NOME")
                    .HasMaxLength(100);

                entity.Property(e => e.NmSobrenomeMae)
                    .HasColumnName("NM_SOBRENOME_MAE")
                    .HasMaxLength(100);

                entity.Property(e => e.NmSobrenomePai)
                    .HasColumnName("NM_SOBRENOME_PAI")
                    .HasMaxLength(100);

                entity.Property(e => e.NmUsuario)
                    .HasColumnName("NM_USUARIO")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.CdCurp)
                    .HasColumnName("CD_CURP")
                    .HasMaxLength(100);

                entity.Property(e => e.CdPessoaFisica)
                    .HasColumnName("CD_PESSOA_FISICA")
                    .HasMaxLength(100);

                entity.Property(e => e.CdRfc)
                    .HasColumnName("CD_RFC")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("DT_NASCIMENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IeSexo)
                    .HasColumnName("IE_SEXO")
                    .HasMaxLength(100);

                entity.Property(e => e.NmAbreviado)
                    .HasColumnName("NM_ABREVIADO")
                    .HasMaxLength(100);

                entity.Property(e => e.NmPessoaFisica)
                    .HasColumnName("NM_PESSOA_FISICA")
                    .HasMaxLength(100);

                entity.Property(e => e.NmPrimeiroNome)
                    .HasColumnName("NM_PRIMEIRO_NOME")
                    .HasMaxLength(100);

                entity.Property(e => e.NmSobrenomeMae)
                    .HasColumnName("NM_SOBRENOME_MAE")
                    .HasMaxLength(100);

                entity.Property(e => e.NmSobrenomePai)
                    .HasColumnName("NM_SOBRENOME_PAI")
                    .HasMaxLength(100);

                entity.Property(e => e.NmUsuario)
                    .HasColumnName("NM_USUARIO")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.HasIndex(e => e.QueryId)
                    .HasName("IX_Query");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComandoSql).IsRequired();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UltSincronizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.Property(e => e.CdSetorAtendimento)
                    .HasColumnName("CD_SETOR_ATENDIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DsDescricao)
                    .HasColumnName("DS_DESCRICAO")
                    .HasMaxLength(150);

                entity.Property(e => e.DsSetorAtendimento)
                    .HasColumnName("DS_SETOR_ATENDIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.IeSituacao)
                    .HasColumnName("IE_SITUACAO")
                    .HasMaxLength(150);

                entity.Property(e => e.NmUnidadeBasica)
                    .HasColumnName("NM_UNIDADE_BASICA")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.Property(e => e.CdSetorAtendimento)
                    .HasColumnName("CD_SETOR_ATENDIMENTO")
                    .HasMaxLength(150);

                entity.Property(e => e.CdUnidadeBasica)
                    .HasColumnName("CD_UNIDADE_BASICA")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DsUnidadeAtend)
                    .HasColumnName("DS_UNIDADE_ATEND")
                    .HasMaxLength(150);

                entity.Property(e => e.IeSituacao)
                    .HasColumnName("IE_SITUACAO")
                    .HasMaxLength(150);

                entity.Property(e => e.IeStatusUnidade)
                    .HasColumnName("IE_STATUS_UNIDADE")
                    .HasMaxLength(150);

                entity.Property(e => e.NrSeqInterno)
                    .HasColumnName("NR_SEQ_INTERNO")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });
        }
    }
}
