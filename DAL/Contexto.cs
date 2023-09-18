using CrossCutting;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class Contexto : DbContext
    {
        
        public Contexto() { }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseMySql(ConfiguracaoTools.RetornaVariavelConfiguracoes("ConnectionStrings:DefaultConnection"),
                    ServerVersion.AutoDetect(ConfiguracaoTools.RetornaVariavelConfiguracoes("ConnectionStrings:DefaultConnection")));
            }
        }

        /* Creating DatabaseContext configured by Dependency Injection */
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        
        public DbSet<Mensageria> Mensagerias{ get; set; }
        public DbSet<Configuracao> Confirguracoes{ get; set; }
     

    }
}
