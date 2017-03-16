using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MangaCollection.Controllers
{
    public class MangaController :Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Drifters";
            ViewBag.IssueNumber = 1;
            ViewBag.Description = "<p>Debut issue of an incredible tale of heroism! The story of Drifters takes place during Japan's Sengoku period (roughly XV to XVII century), a time of constant warring between the island's states, and a natural setting of choice for samurai stories. Young samurai on verge of death suddenly finds himself into another, fantastic world. How? Why? These questions remain unanswered...</p>";
            ViewBag.Contributers = new string[]
            {
                "Written: Kouta Hirano",
                "Illustrated:Kouta Hirano",
                "Published: Shonen Gahosha",
                "Translated: Dark Horse Comics"
            };
            return View();
        }
    }
}