using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del Cliente")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [Display(Name = "Apellido del Cliente")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [Display(Name = "Apellido del Cliente")]
        public string Direccion { get; set; }

    }
}
