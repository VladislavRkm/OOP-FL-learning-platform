using Microsoft.AspNetCore.Mvc;

namespace EngLeash.Presentation.Http.Controllers;
public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
