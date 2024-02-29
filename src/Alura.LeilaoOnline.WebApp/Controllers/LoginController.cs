using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing; 

namespace Projeto.LeilaoOnline.WebApp.Controllers
{
    public class LoginController : Controller
    {

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
