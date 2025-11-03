using Microsoft.AspNetCore.Mvc;

public class ProveedoresController : Controller
{
    public IActionResult Index()
    {
        ViewData["Titulo"] = "Gestión de Proveedores";
        return View();
    }
}
