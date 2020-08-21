using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DreamClient.Models;
using Microsoft.AspNetCore.Authorization;

namespace DreamClient.Controllers
{
    public class DreamsController : Controller
    {
        public IActionResult Index()
        {
          var allDreams = Dream.GetDreams();
          return View(allDreams);
        }
        public IActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Create(Dream dream)
        {
          Dream.Post(dream);
          return RedirectToAction("Index");
        }
        public IActionResult Filter(string search)
        {
          List<Dream> searchObject = new List<Dream> {};
          var allDreams = Dream.GetDreams();
          for (int i = 0; i < allDreams.Count; i++)
          {
            if (search != null && allDreams[i].Title.ToLower().Contains(search.ToLower()))
            {
              searchObject.Add(allDreams[i]);
            }
          }
          return View(searchObject);
        }

    }
}