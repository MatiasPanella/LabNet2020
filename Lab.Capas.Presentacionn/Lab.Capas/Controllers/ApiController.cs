using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.Web.Mvc;
using Lab.Capas.Models;

namespace Lab.Capas.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            string url = "https://rickandmortyapi.com/api/character/";
            var json = new WebClient().DownloadString(url);
            var characters = JsonConvert.DeserializeObject<Root>(json);
            return View(characters);
        }
    }
}