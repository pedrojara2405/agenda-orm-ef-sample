using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    [Table("Contactos")]
    public class Contacto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
    }
}