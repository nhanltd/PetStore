using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStore.Models;
using System.Diagnostics;

namespace PetStore.Controllers
    
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly PetStoreContext _context;

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public HomeController(ILogger<HomeController> logger, PetStoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var petStoreContext = _context.Products.Include(p => p.Category);
            return View(await petStoreContext.ToListAsync());
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
