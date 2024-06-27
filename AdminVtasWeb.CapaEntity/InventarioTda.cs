using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class InventarioTda
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Codigo Articulo")]
        public string? CodigoArticulo { get; set; }

        [Required(ErrorMessage = "El Id Sucursal es obligatorio")]
        [Display(Name = "Id Sucursal")]
        public int IdSucursal { get; set; }

        [Required(ErrorMessage = "El Nombre Sucursal es obligatorio")]
        [Display(Name = "Nombre Sucursal")]
        public string Sucursal { get; set; }

        [Required(ErrorMessage = "El Nombre Articulo es obligatorio")]
        [Display(Name = "Nombre Articulo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Cantidad Inicial es obligatoria")]
        [Display(Name = "Cantidad Inicial")]
        public int Cant_InvInicial { get; set; }

        [Required(ErrorMessage = "Cantidad Actual es obligatoria")]
        [Display(Name = "Cantidad Actual")]
        public int Cant_InvActual { get; set; }

        [Required(ErrorMessage = "Cantidad Ventas es obligatoria")]
        [Display(Name = "Cantidad Ventas")]
        public int Cant_Ventas { get; set; }

    }
}
