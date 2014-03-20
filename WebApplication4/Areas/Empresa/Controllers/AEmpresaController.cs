using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Areas.Empresa.Controllers
{
    public class AEmpresaController : Controller
    {
        //
        // GET: /Empresa/AEmpresa/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastroEmpresa()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastroEmpresa(string Nome,string Area,string Desc)
        {
            ViewBag.nome = Nome;
            return View();
        }
        public ActionResult EditarEmpresa()
        {
            return View();
        }


        public ActionResult DeletarEmpresa()
        {
            return View();
        }
       

	}
}