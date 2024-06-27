using AdminVtasWeb.CapaEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Proy_AdminVtasWeb.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class PedidoController : Controller
    {
        private readonly string cadenaSQL;

        public IActionResult Index()
        {
            return View();
        }

        public PedidoController(IConfiguration configuration)
        {
            cadenaSQL = configuration.GetConnectionString("SQLConexion");
        }
        public IActionResult CargaPedido()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CargaPedido(Pedido pedido)
        {
            using (SqlConnection con = new(cadenaSQL))
            {
                using (SqlCommand cmd = new("sp_guardaPedido", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = pedido.codigo;
                    cmd.Parameters.Add("@IdSucursal", System.Data.SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@Cliente", System.Data.SqlDbType.VarChar).Value = pedido.Cliente;
                    cmd.Parameters.Add("@Cantidad", System.Data.SqlDbType.Int).Value = pedido.Cantidad;
                    cmd.Parameters.Add("@Estado", System.Data.SqlDbType.Int).Value = 1;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return Redirect("Index");
        }


        public IActionResult TraeVenta()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TraeVenta(Venta venta)
        {
            using (SqlConnection con = new(cadenaSQL))
            {
                using (SqlCommand cmd = new("sp_PedidoCliente", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Cliente", System.Data.SqlDbType.VarChar).Value = "vaguilar@live.com";
                    con.Open();
                    SqlDataAdapter da = new(cmd);
                    DataTable dt = new();
                    da.Fill(dt);
                    da.Dispose();

                    List<Venta> lista = new();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lista.Add(new Venta()
                        {
                            IdPedido = Convert.ToInt32(dt.Rows[i][1].ToString()),
                            Sucursal = (dt.Rows[i][3].ToString()),
                            Descripcion = (dt.Rows[i][4].ToString()),
                            Cliente = (dt.Rows[i][5].ToString()),
                            Cantidad = Convert.ToInt32(dt.Rows[i][7].ToString()),
                        });
                    }
                    ViewBag.Venta = lista;
                    con.Close();
                }
                return View();
            }

        }

        public JsonResult obtenerArticulo(string codigo, string b_descripcion, string b_descripcion2)
        {
            using (SqlConnection con = new(cadenaSQL))
            {
                List<Artículo> lista = new();
                using (SqlCommand cmd = new("sp_CatArticulo", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CodArticulo", System.Data.SqlDbType.VarChar).Value = "vaguilar@live.com";
                    con.Open();
                    SqlDataAdapter da = new(cmd);
                    DataTable dt = new();
                    da.Fill(dt);
                    da.Dispose();


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lista.Add(new Artículo()
                        {
                            IdArticulo = Convert.ToInt32(dt.Rows[i][0].ToString()),
                            Codigo = (dt.Rows[i][1].ToString()),
                            Descripcion = (dt.Rows[i][2].ToString()),
                        });
                    }
                    con.Close();
                }
                return Json(lista);
            }

        }

    }
}
