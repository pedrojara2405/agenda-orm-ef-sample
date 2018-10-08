using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    [Table("Telefonos")]
    public class Telefono
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Numero { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
        public Contacto Contacto { get; set; }
        public int ContactoId { get; set; }

    }
}