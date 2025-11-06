using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class ProveedoresController : Controller
{
    // “BD” en memoria para práctica
    private static readonly List<Proveedor> _memoria = new()
    {
        new Proveedor { Id = 1, RazonSocial = "Distribuciones Andinas S.A.S.", Email = "ventas@andinas.com", Telefono = "3021112233" },
        new Proveedor { Id = 2, RazonSocial = "Importadora Visionar LTDA", Email = "contacto@visionar.co", Telefono = "3109876543" }
    };

    // LISTA
    public IActionResult Index()
    {
        var lista = _memoria.OrderBy(p => p.Id).ToList();
        return View(lista);
    }

    // CREAR (GET)
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Proveedor());
    }

    // CREAR (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Proveedor modelo)
    {
        if (!ModelState.IsValid) return View(modelo);

        modelo.Id = _memoria.Any() ? _memoria.Max(p => p.Id) + 1 : 1;
        _memoria.Add(modelo);
        return RedirectToAction(nameof(Index));
    }
}
