using APIViaCep.Controllers;
using Microsoft.EntityFrameworkCore;

namespace APIViaCep.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options)
        
        { 
        }

        public DbSet<Enderecos> Enderecos { get; set; }

    }
}
