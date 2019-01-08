using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rental_WebCore.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Property(int id)
        {
            return View((object)id);
        }

        public IActionResult ListProperty(int id)
        {
            return View((object)id);
        }
    }
}