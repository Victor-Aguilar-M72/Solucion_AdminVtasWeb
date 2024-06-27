using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class Tienda
    {
        [Key]
        public int IdSucursal { get; set; }

        [Required(ErrorMessage = "El nombre de la Sucursal es obligatorio")]
        [Display(Name = "Nombre Sucursal")]
        public string Sucursal { get; set; }

        [Required(ErrorMessage = "La Direccion es obligatoria")]
        [Display(Name = "Direccion Sucursal")]
        public string Direccion { get; set; }

    }
}
