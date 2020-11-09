using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloASPDotNET.Controllers
{
    //[Route("/hello")]
    public class HelloController : Controller
    {

        // GET: /<controller>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /<controller>/welcome
        [HttpPost("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;

            return View();
        }

        //public static string CreateMessage(string name, string language)
        //{
        //    string greeting = $"Hello, {name}!";

        //    if (language == "spanish")
        //    {
        //        greeting = $"Hola, {name}!";

        //        return greeting;
        //    }
            
        //    if (language == "danish")
        //    {
        //        greeting = $"Hej, {name}!";

        //        return greeting;
        //    }
            
        //    if (language == "french")
        //    {
        //        greeting = $"Bonjour, {name}!";

        //        return greeting;
        //    }
            
        //    if (language == "pirate")
        //    {
        //        greeting = $"Ahoy, {name}!";

        //        return greeting;
        //    }
            

        //    return greeting;
        //}
    }
}
