using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Rental_WebCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_WebCore.Controllers
{
    public class AssetController : Controller
    {
        // GET: /<controller>/
        public IActionResult HomeAsset()
        {
            return View();
        }
        public IActionResult TypesAsset()
        {
            return View();
        }
        public IActionResult ViewDetailAsset()
        {
            return View();
        }
  
    }
}