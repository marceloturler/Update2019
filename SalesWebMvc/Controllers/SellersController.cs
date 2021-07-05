using System;
using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var listSellers = _sellerService.FindAll();
            return View(listSellers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller objSeller)
        {
            _sellerService.Insert(objSeller);
            return RedirectToAction(nameof(Index));
        }
    }
}
