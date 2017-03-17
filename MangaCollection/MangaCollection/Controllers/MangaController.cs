using MangaCollection.Data;
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
        private MangaRepo _mangaRepo = null;

        public MangaController()
        {
            _mangaRepo = new MangaRepo();
        }

        public ActionResult Detail(int? id)
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            var manga = _mangaRepo.GetManga(id.Value);
            return View(manga);
        }
    }
}