using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string pesquisa)
        {
            if(pesquisa!=null)
            {
                return RedirectToAction("ResultadoPesquisa");
            }
            return View();
        }
       
        public ActionResult ResultadoPesquisa()
        {
            return View();
        }
        
	}
}