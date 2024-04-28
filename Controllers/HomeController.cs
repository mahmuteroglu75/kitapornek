using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kitap_Örneği.Models;
using MvcProje.Models;
using System.ComponentModel.DataAnnotations;

namespace Kitap_Örneği.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Kitap Kitap = new Kitap
            {
                KitapAdi = "Körler Ülkesinde Işık Saçanlar",
                YazarAdi = "Halide Edip Adıvar",
                YayinlanmaTarihi = new DateTime(1924, 1, 1),
                Turu = "Roman",
                SayfaSayisi = 320,
                Fiyat = 35.90M
            };
            return View(Kitap);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
