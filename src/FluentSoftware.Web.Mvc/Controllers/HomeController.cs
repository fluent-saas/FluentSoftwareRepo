using Abp.AspNetCore.Mvc.Authorization;
using FluentSoftware.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FluentSoftware.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FluentSoftwareControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}