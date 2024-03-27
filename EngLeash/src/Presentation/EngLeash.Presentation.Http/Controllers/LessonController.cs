using Microsoft.AspNetCore.Mvc;

namespace EngLeash.Presentation.Http.Controllers;
public class LessonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
