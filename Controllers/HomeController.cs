using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instanciando a classe cliente
        Cliente cliente1 = new Cliente(1,"José Maria","11111111111", "jm@teste.com","totó");
        Cliente cliente2 = new Cliente(2,"Maria José","22222222222","mj@gmail.com","bichano");
        Cliente cliente3 = new Cliente(3,"João Paulo","jp@yahoo","33333333333", "Touche");
        Cliente cliente4 = new Cliente(4,"Madalena Silva", "44444444444","ms@teste.com", "Pernalonga");
        Cliente cliente5 = new Cliente(5,"Poncio Pilatos","55555555555", "pp@teste.com", "piu piu");
        return View();
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
