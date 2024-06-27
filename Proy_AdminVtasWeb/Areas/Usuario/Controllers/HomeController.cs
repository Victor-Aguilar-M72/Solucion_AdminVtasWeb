using AdminVtasWeb.CapaEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proy_AdminVtasWeb.Models;
using System.Diagnostics;

namespace Proy_AdminVtasWeb.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //****************//
        //public IConfiguration Configuration { get; }

        //public HomeController(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IActionResult AgregaArticulo()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AgregaArticulo(Artículo artículo)
        //{
        //    string connectionString = "server=DESKTOP-IJ6ICD3; database = AdminVtasWeb; user=sa; password=arturo73; TrustServerCertificate=True;";
        //   // using (SqlConnection con = new(Configuration["ConnectionStrings.SQLConexion"]))

        //    using (SqlConnection con =
        //                new(connectionString))
        //    {

        //        using (SqlCommand cmd = new("sp_guardaArticulo", con))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar).Value = artículo.Codigo;
        //            cmd.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar).Value = artículo.Descripcion;
        //            cmd.Parameters.Add("@Precio", System.Data.SqlDbType.Decimal).Value = artículo.Precio;
        //            cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.VarChar).Value = artículo.Imagen;
        //            cmd.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = artículo.stock;
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //    return Redirect("Index");
        //}


        //****************//






        public IActionResult Privacy()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
