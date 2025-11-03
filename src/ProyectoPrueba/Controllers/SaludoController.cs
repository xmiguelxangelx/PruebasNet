using Microsoft.AspNetCore.Mvc;

public class SaludoController : Controller
{
    public IActionResult Hola()
    {
        ViewData["Nombre"] = "Miguel";
        return View();
    }
        public IActionResult HolaAprendiz()
    {
        ViewData["Mensaje"] = "Bienvenido al mundo MVC en .NET 9";
        return View();
    }
}

