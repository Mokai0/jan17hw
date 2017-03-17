using MangaCollection.Models;
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
            var manga = new Manga()
            {
                SeriesTitle = "Drifters",
                IssueNumber = 1,
                DescriptionHtml = "<p>Debut issue of an incredible tale of heroism! The story of Drifters takes place during Japan's Sengoku period (roughly XV to XVII century), a time of constant warring between the island's states, and a natural setting of choice for samurai stories. Young samurai on verge of death suddenly finds himself into another, fantastic world. How? Why? These questions remain unanswered...</p>",
                Contributers = new Contributer[]
                {
                    new Contributer() {Name = "Kouta Hirano", Role = "Written" },
                    new Contributer() {Name = "Kouta Hirano", Role = "Illustrated" },
                    new Contributer() {Name = "Shonen Gahosha", Role = "Published" },
                    new Contributer() {Name = "Dark Horse Comics", Role = "Translated" },
                }
            };

            return View(manga);
        }
    }
}