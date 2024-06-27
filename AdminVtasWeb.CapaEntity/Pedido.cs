using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminVtasWeb.CapaEntity
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "El IdArticulo es obligatorio")]
        [Display(Name = "IdArticulo")]
        public int IdArticulo { get; set; }

        [Required(ErrorMessage = "El codigo es obligatorio")]
        [Display(Name = "Codigo")]
        public string codigo { get; set; }

        [Required(ErrorMessage = "El IdSucursal es obligatorio")]
        [Display(Name = "IdSucursal")]
        public int IdSucursal { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El Cantidad es obligatorio")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio")]
        [Display(Name = "Estado del Pedido")]
        public int Estado { get; set; }

    }
}
