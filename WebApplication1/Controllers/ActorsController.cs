using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Data.Services;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _services;


        public ActorsController(IActorsService service)
        {
            _services = service;
        }

        public IActionResult Index()
        {
            var data = _services.GetAll();
            return View(data);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create([Bind("FullName ,ProfilePictureUrl, Bio")] Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            else
            {
                await _services.AddAsync(actor);
                return RedirectToAction("Index");
            }
           
        }

        public async Task<IActionResult> Edit(int id)
        {
            var details =  _services.GetByIdAsync(id);
            if (details == null) return View("Not Found");
            return View(details);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit( int id,[Bind("id ,FullName, ProfilePictureUrl, Bio")] Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var actordetails = _services.GetByIdAsync(id);

            if (actordetails == null) return View("Not Found");
            return View(actordetails);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            var actordetails =  _services.GetByIdAsync(id);

            if (actordetails == null) return View("Not Found");
            return View(actordetails);
        }


        [HttpPost , ActionName("Delete")]
        public async Task<IActionResult> Delete(Actor actor)
        {
           
           await _services.DeleteAsync(actor.ID);
            return View(nameof(Index));

        }

       

    }
}
