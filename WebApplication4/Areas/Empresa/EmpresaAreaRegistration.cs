using System.Web.Mvc;

namespace WebApplication4.Areas.Empresa
{
    public class EmpresaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Empresa";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Empresa_default",
                "Empresa/{controller}/{action}/{id}",
                new { action = "Index",controller="AEmpresa", id = UrlParameter.Optional }
            );
        }
    }
}