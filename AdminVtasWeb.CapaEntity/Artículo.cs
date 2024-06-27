using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class Artículo
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required(ErrorMessage = "El Codigo es obligatorio")]
        [Display(Name = "Codigo Artículo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        [Display(Name = "Descripcion Artículo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        [Display(Name = "Precio Artículo")]
        public decimal Precio { get; set; }

        [Display(Name = "Imagen del Artículo")]
        public string Imagen { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        [Display(Name = "stock Artículo")]
        public int stock { get; set; }
    }
}
