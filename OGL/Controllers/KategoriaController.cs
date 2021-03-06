﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repozytorium.IRepo;
using Repozytorium.Models;
using Repozytorium.Models.Views;

namespace OGL.Controllers
{
    public class KategoriaController : Controller
    {
        private readonly IKategoriaRepo _repo;

        public KategoriaController(IKategoriaRepo repo)
        {
            _repo = repo;
        }

        // GET: Kategoria
        public ActionResult Index()
        {
            var kategorie = _repo.PobierzKategorie();
            return View(kategorie);
        }

        public ActionResult PokazOgloszenia(int id)
        {
            var ogloszenia = _repo.PobierzOgloszeniaZKategorii(id);
            OgloszeniaZKategoriiViewModels model = new OgloszeniaZKategoriiViewModels()
            {
                Ogloszenia = ogloszenia.ToList(),
                NazwaKategorii = _repo.NazwaDlaKategorii(id)
            };
            return View(model);
        }

        [Route("JSON")]
        public ActionResult KategorieWJson()
        {
            var kategorie = _repo.PobierzKategorie();
            return Json(kategorie, JsonRequestBehavior.AllowGet);
        }
    }
}
