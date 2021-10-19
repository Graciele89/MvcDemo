using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            //StudentResult studentResult = new() { StudentId = 100, StudentName = "Miss Complaining" };
            //StudentResult studentResult = new() { StudentId = 100, StudentName = "Miss Complaining" };
            //StudentResult studentResult = new() { StudentId = 100, StudentName = "Miss Complaining" };

            return View();
        }
    }
}
