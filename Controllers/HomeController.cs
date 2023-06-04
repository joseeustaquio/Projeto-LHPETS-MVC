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

       //Instanciando a classe fornecedor
        Fornecedor fornecedor1 = new Fornecedor(1,"Pet.SA","11111110001.66", "jm@teste.com");
        Fornecedor fornecedor2 = new Fornecedor(2,"Mundo dog","222220001/77","mj@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(3,"Clinica Animal","333333/0001.88", "ca@teste.com");
        Fornecedor fornecedor4 = new Fornecedor(4,"Socor Bichos", "4444444/0001.99","sb@teste.com");
        Fornecedor fornecedor5 = new Fornecedor(5,"Veterinaria pet","55555/0001.11", "vp@teste.com");
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
