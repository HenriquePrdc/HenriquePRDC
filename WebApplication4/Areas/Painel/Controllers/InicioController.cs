using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication4.Areas.Painel.Controllers
{
    public class InicioController : Controller
    {
        public string NameUser { get; set; }
        //
        // GET: /Painel/Inicio/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Nome, string Senha)
        {

            if (Nome == "Henrique" && Senha == "123")
            {
                NameUser = Nome;
                return RedirectToAction("DadosCadastrais");
            }
            return View();
        }
        public ActionResult DadosCadastrais()
        {
            return View();
        }
    }
    
}