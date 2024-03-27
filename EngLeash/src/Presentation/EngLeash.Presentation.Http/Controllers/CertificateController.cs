using Microsoft.AspNetCore.Mvc;

namespace EngLeash.Presentation.Http.Controllers;
public class CertificateController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
