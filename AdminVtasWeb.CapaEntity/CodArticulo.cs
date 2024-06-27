using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminVtasWeb.CapaEntity
{
    internal class CodArticulo
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required(ErrorMessage = "El Codigo es obligatorio")]
        [Display(Name = "Codigo Artículo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        [Display(Name = "Descripcion Artículo")]
        public string Descripcion { get; set; }
    }
}
