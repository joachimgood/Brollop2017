using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using brollop2017.Controllers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace brollop2017
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult foljet()
        {
            return View();
        }

        public IActionResult historia()
        {
            return View();
        }

        public IActionResult toastmasters()
        {
            EmailSender email = new EmailSender();
            //email.send();
            return View();
        }



    }
}
