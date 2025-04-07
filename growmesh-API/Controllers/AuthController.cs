using Microsoft.AspNetCore.Mvc;

namespace growmesh_API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
