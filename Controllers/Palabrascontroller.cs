using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp3.Models;

namespace tp3.Controllers;

public class PalabrasController : Controller
{
    public IActionResult Index()
    {
        PalabrasAhorcado palabrasAhorcado = new PalabrasAhorcado();
        ViewBag.Palabra = palabrasAhorcado.obtenerPalabra();
        return View();
    }
    public IActionResult AgregarPalabra(string palabra)
    {
        PalabrasAhorcado palabrasAhorcado = new PalabrasAhorcado();
        ViewBag.Mensaje = palabrasAhorcado.agregarPalabra(palabra);
        return View();
    }
}