using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class ClientesController : Controller
{
    // “BD” en memoria para práctica
    private static readonly List<Cliente> _memoria = new()
    {
        new Cliente { Id = 1, Nombre = "Juan Pérez", Email = "juan@example.com", Telefono = "3001234567" },
        new Cliente { Id = 2, Nombre = "Ana Gómez", Email = "ana@example.com", Telefono = "3019876543" }
    };

    // LISTA
    public IActionResult Index()
    {
        var lista = _memoria.OrderBy(c => c.Id).ToList();
        return View(lista); // vista fuertemente tipada
    }

    // CREAR (GET)
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Cliente());
    }

    // CREAR (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Cliente modelo)
    {
        if (!ModelState.IsValid) return View(modelo);

        modelo.Id = _memoria.Any() ? _memoria.Max(c => c.Id) + 1 : 1;
        _memoria.Add(modelo);
        return RedirectToAction(nameof(Index));
    }
}
