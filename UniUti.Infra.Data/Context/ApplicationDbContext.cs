using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniUti.Infra.Data.Identity;
using UniUti.Domain.Models;

namespace UniUti.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<EnderecoInstituicao> EnderecosInstituicao { get; set; }
        public DbSet<EnderecoUsuario> EnderecosUsuario { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Monitoria> Monitorias { get; set; }
        public DbSet<LoggingAplication> Logs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            // Curso
            mb.Entity<Curso>().HasKey(x => x.Id);
            mb.Entity<Curso>().Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Nome");
            mb.Entity<Curso>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            // Disciplina
            mb.Entity<Disciplina>().HasKey(x => x.Id);
            mb.Entity<Disciplina>().Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Nome");
            mb.Entity<Disciplina>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            // Endereço Instituicao
            mb.Entity<EnderecoInstituicao>().HasKey(x => x.Id);
            mb.Entity<EnderecoInstituicao>().Property(x => x.Cep)
                .HasMaxLength(8)
                .IsRequired()
                .HasColumnName("Cep");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Rua)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Rua");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Numero)
                .HasMaxLength(10)
                .IsRequired()
                .HasColumnName("Numero");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Cidade)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Cidade");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Estado)
                .HasMaxLength(2)
                .IsRequired()
                .HasColumnName("Estado");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Pais)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Pais");
            mb.Entity<EnderecoInstituicao>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            // Endereço Usuario
            mb.Entity<EnderecoUsuario>().HasKey(x => x.Id);
            mb.Entity<EnderecoUsuario>().Property(x => x.Cep)
                .HasMaxLength(8)
                .IsRequired()
                .HasColumnName("Cep");
            mb.Entity<EnderecoUsuario>().Property(x => x.Rua)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Rua");
            mb.Entity<EnderecoUsuario>().Property(x => x.Numero)
                .HasMaxLength(10)
                .IsRequired()
                .HasColumnName("Numero");
            mb.Entity<EnderecoUsuario>().Property(x => x.Cidade)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Cidade");
            mb.Entity<EnderecoUsuario>().Property(x => x.Estado)
                .HasMaxLength(2)
                .IsRequired()
                .HasColumnName("Estado");
            mb.Entity<EnderecoUsuario>().Property(x => x.Pais)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Pais");
            mb.Entity<EnderecoUsuario>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            // Instituicao
            mb.Entity<Instituicao>().HasKey(x => x.Id);
            mb.Entity<Instituicao>().Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Nome");
            mb.Entity<Instituicao>().Property(x => x.Telefone)
                .HasMaxLength(10)
                .IsRequired()
                .HasColumnName("Telefone");
            mb.Entity<Instituicao>().Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Email");
            mb.Entity<Instituicao>().Property(x => x.Celular)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("Celular");
            mb.Entity<Instituicao>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            // Usuario
            mb.Entity<ApplicationUser>().HasKey(x => x.Id);
            mb.Entity<ApplicationUser>().Property(x => x.NomeCompleto)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnName("NomeCompleto");
            mb.Entity<ApplicationUser>().Property(x => x.Celular)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("Celular");
            mb.Entity<ApplicationUser>().Property(x => x.Deletado)
                .HasColumnName("Deletado");

            //Monitorias
            mb.Entity<Monitoria>().HasKey(x => x.Id);
            mb.Entity<Monitoria>().Property(x => x.SolicitanteId).IsRequired();
            mb.Entity<Monitoria>().Property(x => x.Descricao)
                .HasMaxLength(500)
                .IsRequired()
                .HasColumnName("Descricao");
            mb.Entity<Monitoria>().Property(x => x.CreatedAt).IsRequired();
            mb.Entity<Monitoria>().Property(x => x.StatusSolicitacao)
                .IsRequired()
                .HasColumnName("Status_solicitacao");
            mb.Entity<Monitoria>().Property(x => x.TipoSolicitacao)
                .IsRequired()
                .HasColumnName("Tipo_solicitacao");

            //Relacionamentos
            mb.Entity<Instituicao>().HasMany(x => x.Enderecos).WithOne(x => x.Instituicao).HasForeignKey(x => x.InstituicaoId).IsRequired(false);
            mb.Entity<Disciplina>().HasMany(x => x.Monitorias).WithOne(x => x.Disciplina).HasForeignKey(x => x.DisciplinaId).IsRequired();
            mb.Entity<ApplicationUser>().HasOne(x => x.Instituicao).WithMany().HasForeignKey(x => x.InstituicaoId).IsRequired(false);
            mb.Entity<ApplicationUser>().HasOne(x => x.Curso).WithMany().HasForeignKey(x => x.CursoId).IsRequired(false);
            mb.Entity<ApplicationUser>().HasMany(x => x.MonitoriasSolicitadas).WithOne().HasForeignKey(x => x.SolicitanteId);
            mb.Entity<ApplicationUser>().HasMany(x => x.MonitoriasOfertadas).WithOne().HasForeignKey(x => x.PrestadorId);
            mb.Entity<ApplicationUser>().HasMany(x => x.Enderecos).WithOne().HasForeignKey(x => x.ApplicationUserId).IsRequired();
        }
    }
}