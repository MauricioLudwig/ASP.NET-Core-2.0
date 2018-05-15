using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lecture5.Models;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Targets;

namespace Lecture5.Controllers
{
    public class HomeController : Controller
    {

        private ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Index page says hello");

            DateTime shortDate = new DateTime(2018, 5, 15);
            var file = (FileTarget)LogManager.Configuration.FindTargetByName("ownFile-web");
            var logEventInfo = new LogEventInfo { TimeStamp = shortDate };
            string fileName = file.FileName.Render(logEventInfo);

            return View(System.IO.File.ReadAllLines(fileName));
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
