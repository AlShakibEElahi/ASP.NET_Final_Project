using MuMerch.Clients;
using MuMerch.Cus_Auth;
using MuMerch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    [BandManagerAccess]
    public class BandManagerController : Controller
    {
        // GET: BandManager
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> UserList()
        {
            var data = await MuMerchClientGet.Get<List<BandManager>>("band/all");
            return View(data);
        }

    }
}