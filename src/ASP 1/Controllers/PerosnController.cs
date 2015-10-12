using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASP_1.Models.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new Person());
        }
    }
}
