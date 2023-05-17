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
                    Session["TokenKey"] = token.TokenKey;
                    var id = token.UserId;
                    Session["Id"] = id;
                    var user = await MuMerchClientGet.Get<User>($"user/{id}");
                    Session["UserType"] = user.UserType;
                    if (Session["UserType"].Equals("Admin")) return RedirectToAction("Index", "Admin");
                    if (Session["UserType"].Equals("Employee")) return RedirectToAction("Index", "Employee");
                    if (Session["UserType"].Equals("BandManager")) return RedirectToAction("Index", "BandManager");
                    if (Session["UserType"].Equals("GigManager")) return RedirectToAction("Index", "GigManager");
                    return View();
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
        public ActionResult Logout()
        {
            Session["UserType"] = null;
            Session["Id"] = null;
            Session["TokenKey"] = null;
            return RedirectToAction("Index", "Auth");
        }
    }
}