using ContactManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactManagementSystem.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> logger;

        public ContactController(ILogger<ContactController> logger)
        {
            this.logger = logger;
        }

        //public IActionResult Index(string value)
        // {
        //    logger.LogInformation($"received name: {value}");
        //    this.ViewData["name"] = value;
        //    return View();
        //}

        //public IActionResult Index([FromRoute(Name ="value")]string name)
        //{
        //    logger.LogInformation($"received name: {name}");
        //    this.ViewData["name"] = name;
        //    return View();
        //}

        //public IActionResult Index([FromRoute(Name = "value")] string name)
        //{
        //    logger.LogInformation($"received name: {name}");
        //    this.ViewBag.UserName = name;
        //    return View();
        //}

        public IActionResult Index([FromRoute(Name = "value")] string name)
        {
            logger.LogInformation($"received name: {name}");
            this.ViewData["name"] = name;
            this.ViewBag.UserName = name;

            //this data will stored in a viewdatadictionary object actually
            //return View(nameof(Index), name);
            return this.View(new List<string> { "anil", "sunil" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
