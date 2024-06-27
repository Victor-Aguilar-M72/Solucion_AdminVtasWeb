using AdminVtasWeb.CapaEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proy_AdminVtasWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
        public DbSet<Artículo> Artículo { get; set; }
        public DbSet<InventarioTda> InventarioTda { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Venta> Venta { get; set; }
        
    }
}
