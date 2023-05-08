using MuMerch.Clients;
using MuMerch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var data = MuMerchClientGet.Get<List<Grade>>("grade/all");
            return View(data);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Grade grade)
        {
            var data = MuMerchClientPost.Post<Grade>("grade/add", grade);
            return RedirectToAction("List");
        }
    }
}