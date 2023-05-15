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
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddUser(User user)
        {
            user.Image = "1";
            try
            {
                var token = await MuMerchClientPost.Post<int>("user/add", user);
                if (token > 0)
                {

                    return RedirectToAction("UserList");
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
        public ActionResult EditUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> EditUser(User user)
        {
            user.Image = "1";
            try
            {
                var token = await MuMerchClientPost.Post<int>("user/edit", user);
                if (token > 0)
                {

                    return RedirectToAction("UserList");
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
        public ActionResult DeleteUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteUser(User user)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("user/delete", user);
                if (token > 0)
                {

                    return RedirectToAction("UserList");
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
        public ActionResult UserList()
        {
            var data = MuMerchClientGet.Get<List<User>>("user/all");
            return View(data);
        }
        [HttpGet]
        public ActionResult AddSize()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddSize(Size size)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("size/add", size);
                if (token > 0)
                {
                    return RedirectToAction("SizeList");
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
        public ActionResult SizeList()
        {
            var data = MuMerchClientGet.Get<List<Size>>("size/all");
            return View(data);
        }
        [HttpGet]
        public ActionResult AddColor()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddColor(Color color)
        {
            color.UpdatedAt = DateTime.Now;
            color.UpdatedBy = "1";
            try
            {
                var token = await MuMerchClientPost.Post<int>("color/add", color);
                if (token > 0)
                {
                    return RedirectToAction("ColorList");
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
        public ActionResult ColorList()
        {
            var data = MuMerchClientGet.Get<List<Color>>("color/all");
            return View(data);
        }

    }
}