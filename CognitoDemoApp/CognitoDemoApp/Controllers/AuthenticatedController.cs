using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CognitoDemoApp.Controllers
{
    [Authorize]
    public class AuthenticatedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
