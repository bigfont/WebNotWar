using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5RC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Trace.TraceInformation("{0}: This is an informational trace message", DateTime.Now);
            Trace.TraceWarning("{0}: Here is trace warning", DateTime.Now);
            Trace.TraceError("{0}: Something is broken; tracing an error!", DateTime.Now);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
