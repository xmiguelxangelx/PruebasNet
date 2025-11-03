using Microsoft.AspNetCore.Mvc;

public class ClientesController : Controller
{
    public IActionResult Index()
    {
        ViewData["Titulo"] = "Gestión de Clientes";
        return View();
    }
}
