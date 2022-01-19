using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace github.Controllers
{
    public class NoviController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
