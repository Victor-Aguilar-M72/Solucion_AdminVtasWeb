using AdminVtasWeb.CapaEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Proy_AdminVtasWeb.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class ArticuloController : Controller
    {
        private readonly string cadenaSQL;

        public IActionResult Index()
        {
            return View();
        }
        public ArticuloController(IConfiguration configuration)
        {
            cadenaSQL = configuration.GetConnectionString("SQLConexion");
        }

        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Artículo artículo)
        {
            using (SqlConnection con = new(cadenaSQL))
            {
                using (SqlCommand cmd = new("sp_guardaArticulo", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar).Value = artículo.Codigo;
                    cmd.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar).Value = artículo.Descripcion;
                    cmd.Parameters.Add("@Precio", System.Data.SqlDbType.Decimal).Value = artículo.Precio;
                    cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.VarChar).Value = artículo.Imagen;
                    cmd.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = artículo.stock;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return Redirect("Index");
        }



        public IActionResult TraeInventarioTda()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TraeInventarioTda(InventarioTda inventariotda)
        {
            using (SqlConnection con = new(cadenaSQL))
            {
                using (SqlCommand cmd = new("sp_InventarioSucursal", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@IdSucursal", System.Data.SqlDbType.VarChar).Value = inventariotda.IdSucursal;
                    cmd.Parameters.Add("@IdSucursal", System.Data.SqlDbType.VarChar).Value = 1;
                    con.Open();
                    SqlDataAdapter da = new(cmd);
                    DataTable dt = new();
                    da.Fill(dt);
                    da.Dispose();
                    List<InventarioTda> lista = new();
                    for (int i=0; i< dt.Rows.Count; i++)
                    {
                        lista.Add(new InventarioTda()
                        {
                            CodigoArticulo = (dt.Rows[i][1].ToString()),
                            Sucursal = (dt.Rows[i][2].ToString()),
                            Descripcion = (dt.Rows[i][3].ToString()),
                            Cant_InvInicial = Convert.ToInt32(dt.Rows[i][4].ToString()),
                            Cant_InvActual = Convert.ToInt32(dt.Rows[i][5].ToString()),
                            Cant_Ventas = Convert.ToInt32(dt.Rows[i][6].ToString())

                        });
                    }
                    ViewBag.InventarioTda = lista;
                    con.Close();
                }
                return View();
            }
            
        }


    }
}
