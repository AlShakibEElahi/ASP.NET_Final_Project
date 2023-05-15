using MuMerch.Clients;
using MuMerch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    public class BandController : Controller
    {
        // GET: Band
        [HttpGet]
        public ActionResult AddBand()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddBand(Band band)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("band/add", band);
                    if (token > 0)
                    {

                        return RedirectToAction("BandList");
                    }
                    else
                    {
                        ViewBag.Message = "Invalid login credentials";
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error logging in: " + ex.Message;
                    return View();
                }
            }
            return View(band);
        }
        [HttpGet]
        public async Task<ActionResult> EditBand(string id)
        {
            var data = await MuMerchClientGet.Get<Band>($"band/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditBand(Band band)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("band/add", band);
                    if (token > 0)
                    {

                        return RedirectToAction("BandList");
                    }
                    else
                    {
                        ViewBag.Message = "Invalid login credentials";
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error logging in: " + ex.Message;
                    return View();
                }
            }
            return View(band);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteBand(string id)
        {
            var data = await MuMerchClientGet.Get<Band>($"band/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteBand(Band band)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("band/delete", band);
                if (token > 0)
                {

                    return RedirectToAction("BandList");
                }
                else
                {
                    ViewBag.Message = "Invalid login credentials";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error logging in: " + ex.Message;
                return View();
            }
        }
        [HttpGet]
        public async Task<ActionResult> BandList()
        {
            var data = await MuMerchClientGet.Get<List<Band>>("band/all");
            return View(data);
        }
    }
}