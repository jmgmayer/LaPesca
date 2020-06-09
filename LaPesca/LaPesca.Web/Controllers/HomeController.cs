using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaPesca.Web.Models;
using LaPesca.Models;
using LaPesca.Tools.Services;

namespace LaPesca.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContextLP _dbContext;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, DataContextLP dataContext, IEmailSender emailSender)
        {
            _logger = logger;
            _dbContext = dataContext;
            _emailSender = emailSender;            
        }

        public IActionResult Index()
        {

            //var hoteles = _dbContext.Hoteles.Where(c => c.Estatus == true);
            //_emailSender.SenderEMailAsync("","","");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
