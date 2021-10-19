using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = ProductRepository.GetProducts();

            return View(products);
        }
    }
}
