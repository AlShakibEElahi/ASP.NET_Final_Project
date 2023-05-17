using MuMerch.Cus_Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    [GigManagerAccess]
    public class GigManagerController : Controller
    {
        // GET: GigManager
        public ActionResult Index()
        {
            return View();
        }
    }
}