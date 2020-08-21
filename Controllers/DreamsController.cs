using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DreamClient.Models;

namespace DreamClient.Controllers
{
    public class DreamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}