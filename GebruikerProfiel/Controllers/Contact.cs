using Microsoft.AspNetCore.Mvc;

namespace GebruikerProfiel.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
