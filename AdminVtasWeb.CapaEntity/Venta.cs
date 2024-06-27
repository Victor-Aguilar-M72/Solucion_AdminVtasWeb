using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "El IdPedido es obligatorio")]
        [Display(Name = "IdPedido")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "El IdSucursal es obligatorio")]
        [Display(Name = "IdSucursal")]
        public int IdSucursal { get; set; }

        [Required(ErrorMessage = "la Sucursal es obligatoria")]
        [Display(Name = "Sucursal")]
        public string Sucursal { get; set; }

        [Required(ErrorMessage = "la Sucursal es obligatoria")]
        [Display(Name = "Sucursal")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio")]
        [Display(Name = "Cliente ")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        [Display(Name = "Precio ")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "El ImporteVenta es obligatorio")]
        [Display(Name = "ImporteVenta")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El ImporteVenta es obligatorio")]
        [Display(Name = "ImporteVenta")]
        public int ImporteVenta { get; set; }
    }
}
