using MyHobbies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oefeningenreeks2.Controllers
{
    public class BandController : Controller
    {

        public List<Band> bands;
        public BandController()
        {
            bands = new List<Band>() { new Band { Naam = "test", Jaar=1996 } };
        }
        public IActionResult Index()
        {
            ViewBag.message = "Welkom bij uw Band app. Hier komt u alles te weten over de bands en hun leden.";
            return View();
        }
        public IActionResult Lijst()
        {
            ViewBag.bands = bands;
            return View();
        }
        public IActionResult Maak(string naam, int jaar)
        {
            Band band = new Band{
                    Naam = naam,
                    Jaar = jaar
            };
            bands.Add(band);
            ViewBag.band = band;
            return View();
        }
    }
}