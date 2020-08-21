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
        public IActionResult Details(string search)
        {
          List<Dream> searchObject = new List<Dream> {};
          var allDreams = Dream.GetDreams();
          for (int i = 0; i < allDreams.Count; i++)
          {
            if (search != null && allDreams[i].Title.ToLower().Contains(search.ToLower()))
            {
              searchObject.Add(allDreams[i]);
            }
            else
            {
              searchObject.Add(allDreams[i]);
            }
          }
          return View(searchObject);
        }

    }
}