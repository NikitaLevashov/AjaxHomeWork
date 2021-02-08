using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ListShopsWEB.Models;
using ListShopsDAL.Mapping;
using ListShopsDAL.Repository;
using ListShopsBLL.ModelsBLL;
using ListShopsBLL.interfaces;

namespace ListShopsWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetShopsRepository _repository;

        public HomeController(IGetShopsRepository repository)
        {
            _repository = repository;
        }

        public IActionResult ListShops()
        {
            var shopsList = _repository.ShopsBLL.ToList();
            ViewBag.Shops = shopsList;

            return PartialView(shopsList);
        }
        public IActionResult ShowInformationOfShop(int positionShopOfTableInView)
        {
            var shopsList = _repository.ShopsBLL.ToList();
            ViewBag.Shops = shopsList[positionShopOfTableInView];

            return PartialView(shopsList[positionShopOfTableInView]);
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
