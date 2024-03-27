using Microsoft.AspNetCore.Mvc;

namespace EngLeash.Presentation.Http.Controllers;
public class CourseController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
