using Exo.WebApi.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {

        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;Password=12345;Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=False;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}