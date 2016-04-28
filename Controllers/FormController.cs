using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace robin.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Example1(string name, string name2)
        {
            ViewData["name"] = name;
            ViewData["name2"] = name2;

            return View();
        }

    }
}
