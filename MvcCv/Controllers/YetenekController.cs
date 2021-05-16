using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();

        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
    }
}