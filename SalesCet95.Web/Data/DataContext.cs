using Microsoft.EntityFrameworkCore;
using SalesCet95.Web.Data.Entity;

namespace SalesCet95.Web.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Construtor para inicializar o contexto de dados com as opções fornecidas.
            // Isso permite a configuração da conexão com o banco de dados e outras configurações.
        }

        public DbSet<Country> Countries { get; set; } = null!;

    }
}
