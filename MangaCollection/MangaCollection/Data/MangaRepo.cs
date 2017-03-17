using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MangaCollection.Models;

namespace MangaCollection.Data
{
    public class MangaRepo
    {
        private static Manga[] _mangas = new Manga[]
        {
            new Manga()
            {
                Id = 1,
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
            },
            new Manga()
            {
                Id = 2,
                SeriesTitle = "Drifters",
                IssueNumber = 64,
                DescriptionHtml = "<p>Oh shit! It's the newest issue of Drifters!!!</p>",
                Contributers = new Contributer[]
                {
                    new Contributer() {Name = "Kouta Hirano", Role = "Written" },
                    new Contributer() {Name = "Kouta Hirano", Role = "Illustrated" },
                    new Contributer() {Name = "Shonen Gahosha", Role = "Published" },
                    new Contributer() {Name = "Dark Horse Comics", Role = "Translated" },
                }
            },
            new Manga()
            {
                Id = 3,
                SeriesTitle = "OnePunch Man",
                IssueNumber = 1,
                DescriptionHtml = "<p>In this new action-comedy, everything about a young man named Saitama screams \"AVERAGE,\" from his lifeless expression, to his bald head, to his unimpressive physique. However, this average-looking fellow doesn't have your average problem... He's actually a superhero that's looking for tough opponents! The problem is, every time he finds a promising candidate he beats the snot out of them in one punch. Can Saitama finally find an evil villain strong enough to challenge him? Follow Saitama through his hilarious romps as he searches for new bad guys to challenge!</p>",
                Contributers = new Contributer[]
                {
                    new Contributer() {Name = "One", Role = "Written" },
                    new Contributer() {Name = "Yusuke Murata", Role = "Illustrated" },
                    new Contributer() {Name = "Shueisha", Role = "Published" },
                    new Contributer() {Name = "Viz Media", Role = "Translated" },
                }
            }
        };

        public Manga GetManga(int id)
        {
            Manga mangaChosen = null;

            foreach (var manga in _mangas)
            {
                if (manga.Id == id)
                {
                    mangaChosen = manga;
                    break;
                }
            }

            return mangaChosen;
        }
    }
}