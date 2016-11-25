using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
/*
 * Returns the page with initial core help view (contains different useful links) 
 * 
 * Should be deleted later
 * */

namespace DevIdeas.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult HelpPage()
        {
            return View();
        }
    }
}