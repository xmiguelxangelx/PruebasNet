using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

public class ProductosController : Controller
{
    // “base de datos” en memoria ya que no existe base de datos real
    private static readonly List<Producto> _memoria = new()
    {
        new Producto { Id = 1, Nombre = "Gafas", Precio = 120000, Stock = 5 },
        new Producto { Id = 2, Nombre = "Lentes de contacto", Precio = 80000, Stock = 12 }
    };

    // LISTA
    public IActionResult Index()
    {
        var lista = _memoria.OrderBy(p => p.Id).ToList();
        return View(lista);                 // <- pasamos un modelo fuertemente tipado
    }

    // CREAR (GET)
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Producto());
    }

    // CREAR (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Producto modelo)
    {
        if (!ModelState.IsValid) return View(modelo);

        modelo.Id = _memoria.Any() ? _memoria.Max(p => p.Id) + 1 : 1;
        _memoria.Add(modelo);
        return RedirectToAction(nameof(Index));
    }
}
