using _27_06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using _27_06.Services.Interface;
using _27_06.Classi;

namespace _27_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVenditeService _venditeService;
        private readonly ISaleService _saleService;

        public HomeController(ILogger<HomeController> logger,IVenditeService venditeService, ISaleService saleService )
        {
            _logger = logger;
            _venditeService = venditeService;
            _saleService = saleService;
        }

        public IActionResult Index()
        {
            return View(_venditeService.GetStatistiches());
        }

        public IActionResult Compra()
        {
            var fullSale = _venditeService.GetStatistiches().Where(x => x.BigliettiTotaliVenduti == x.sala.Posti).Select(x => x.sala);
            var sale = _saleService.GetSale().Where(x => !fullSale.Contains(x)).OrderBy(x => x.Nome);
            ViewBag.Sale = sale;
            return View(new VenditeViewModel{ Sale = sale });
        }

        [HttpPost]
        public IActionResult Compra(VenditeViewModel model) { 
            var sala = _saleService.GetSale().Single(Single => Single.Id == model.SalaId);
            _venditeService.AddVendita(new Vendita
            {
                Sala = sala,
                Biglietto = new Biglietto { Tipo = model.Tipo },
               Cliente = new Cliente { Nome = model.NomeSpettatore, Cognome = model.CognomeSpettatore }
            });
            return RedirectToAction("Index");

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
}
