﻿using DemoExistingDbMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoExistingDbMvc.Controllers
{
    public class ActorsController : Controller
    {
        private ActorDbContext _context;

        public ActorsController(ActorDbContext context)
        {
            // Provided by Dependency Injection
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Actors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actors actors)
        {
            if (ModelState.IsValid)
            {
                _context.Actors.Add(actors);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actors);
        }
    }
}
