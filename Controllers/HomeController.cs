using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Urquizo_Brasburg.Models;

namespace TP04_Urquizo_Brasburg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        Juego.InicializarJuego();
        ViewBag.VBIndex = Juego.DicPalabraJuego;
        return View();
    }
    public IActionResult IrAlJuego()
    {
        Juego.InicializarJuego();
        ViewBag.VBJuego = Juego.DicPalabraJuego;
        ViewBag.VBComoVa = Juego.Principio();
        ViewBag.ListLetrasUsuario = Juego.ListLetrasUsuario;

        return View("Juego");
    }
    public IActionResult CompararLetra(char letra)
    {
        ViewBag.EstaLetra = Juego.ContieneESALetra (letra) ;
       
        if(ViewBag.EstaLetra)
        {
          ViewBag.VBComoVa = Juego.MostarComoVa(letra);
          ViewBag.Intentos = Juego.contadorInt;
          ViewBag.ListLetrasUsuario = Juego.ListLetrasUsuario;

        }else
         {
        ViewBag.ListLetrasUsuario = Juego.ListLetrasUsuario;
        }
        return View("Juego");

    }



    public IActionResult CompararPalabra(string PalabraUsario)
    {
        ViewBag.VBCompPalabra = Juego.ContienePalabra(PalabraUsario);
        return View("Juego");

    }




}
