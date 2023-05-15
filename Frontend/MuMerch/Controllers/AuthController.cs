using MuMerch.Clients;
using MuMerch.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(Login login)
        {
            try
            {
                var token = await MuMerchClientPost.Post<Token>("login", login);
                if (token != null)
                {

                    return RedirectToAction("Index", "Home");
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
    }
}