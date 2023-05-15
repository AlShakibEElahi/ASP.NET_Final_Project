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
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
            product.UpdatedAt= DateTime.Now;
            product.UpdatedBy = "sadia@gmailcom";
            if (!ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("product/add", product);
                    if (token > 0)
                    {

                        return RedirectToAction("ProductList");
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
            return View();
        }
        [HttpGet]
        public ActionResult ProductList()
        {
            var data = MuMerchClientGet.Get<List<Product>>("product/all");
            return View(data);
        }
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            var data = MuMerchClientGet.Get<Product>("product/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteProduct(Product product)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("product/delete", product);
                if (token > 0)
                {

                    return RedirectToAction("ProductList");
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

        public ActionResult EditProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> EditProduct(Product product)
        {
            product.Image = "1";
            try
            {
                var token = await MuMerchClientPost.Post<int>("product/edit", product);
                if (token > 0)
                {

                    return RedirectToAction("ProductList");
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