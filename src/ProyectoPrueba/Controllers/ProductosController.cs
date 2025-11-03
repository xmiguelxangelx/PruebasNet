using Microsoft.AspNetCore.Mvc;

public class ProductosController : Controller
{
    public IActionResult Index()
    {
        ViewData["Titulo"] = "Gestión de Productos";
        return View();
    }
}
