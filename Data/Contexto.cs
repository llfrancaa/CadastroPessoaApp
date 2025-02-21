using Microsoft.EntityFrameworkCore;
using CadastroPessoaApp.Models;

namespace CadastroPessoaApp.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}