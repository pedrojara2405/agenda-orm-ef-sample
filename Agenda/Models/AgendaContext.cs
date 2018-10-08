using System.Data.Entity;

namespace Agenda.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
    }
}