using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class ToysController : Controller
    {
        [HttpGet("/tamagotchi")]
        public ActionResult Index()
        {
            List<Toy> toys = Toy.GetAllTamagotchis();
            return View(toys);
        }

        [HttpGet("/tamagotchi/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/tamagotchi")]
        public ActionResult Create(string name)
        {
            Toy toy = new Toy(name);
            return RedirectToAction("Index");
        }

        [HttpGet("/tamagotchi/{id}")]
        public ActionResult Show(int id)
        {
            Toy tamagotchi = Toy.GetToy(id);
            return View(tamagotchi);
        }

        [HttpPost("/tamagotchi/feed/{id}")]
        public ActionResult Feed(int id)
        {
            Toy tamagotchi = Toy.GetToy(id);
            tamagotchi.FeedTamagotchi();
            return RedirectToAction("Index");
        }

        [HttpPost("/tamagotchi/rest/{id}")]
        public ActionResult Rest(int id)
        {
            Toy tamagotchi = Toy.GetToy(id);
            tamagotchi.RestTamagotchi();
            return RedirectToAction("Index");
        }

        [HttpPost("/tamagotchi/play/{id}")]
        public ActionResult Play(int id)
        {
            Toy tamagotchi = Toy.GetToy(id);
            tamagotchi.PlayWithTamagotchi();
            return RedirectToAction("Index");
        }
    }
}