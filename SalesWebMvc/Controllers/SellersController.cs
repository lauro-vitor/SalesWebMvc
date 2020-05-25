
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sallerService;

        public SellersController(SellerService sallerService)
        {
            _sallerService = sallerService;
        }

        public IActionResult Index()
        {
            var list = _sallerService.FindAll();
            return View(list);
        }
    }
}