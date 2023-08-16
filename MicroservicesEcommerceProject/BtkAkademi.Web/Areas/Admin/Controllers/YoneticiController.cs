using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YoneticiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Git()
        {
            return View();
        }

		public IActionResult AdminLogout()
		{
			return SignOut("Cookies", "oidc");
		}


	}
}
