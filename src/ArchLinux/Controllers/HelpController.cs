using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchLinux.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Instalacao() 
        {
            return View();
        }

        public IActionResult PosInstalacao()
        {
            return View();
        }
    }
}
