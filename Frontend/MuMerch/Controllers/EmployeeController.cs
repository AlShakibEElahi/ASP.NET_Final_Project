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
            product.UpdatedAt = DateTime.Now;
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
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCategory(Category category)
        {
            category.UpdatedBy = Session["Id"].ToString();
            category.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("category/add", category);
                    if (token > 0)
                    {

                        return RedirectToAction("CategoryList");
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
            return View(category);
        }
        [HttpGet]
        public async Task<ActionResult> EditCategory(int id)
        {
            var data = await MuMerchClientGet.Get<Category>($"category/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditCategory(Category category)
        {
            category.UpdatedBy = Session["Id"].ToString();
            category.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("category/edit", category);
                    if (token > 0)
                    {

                        return RedirectToAction("CategoryList");
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
            return View(category);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var data = await MuMerchClientGet.Get<Category>($"category/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCategory(Category category)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("category/delete", category);
                if (token > 0)
                {

                    return RedirectToAction("CategoryList");
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
        public async Task<ActionResult> CategoryList()
        {
            var data = await MuMerchClientGet.Get<List<Category>>("category/all");
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
            size.UpdatedBy = Session["Id"].ToString();
            size.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
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
            return View(size);
        }
        [HttpGet]
        public async Task<ActionResult> EditSize(int id)
        {
            var data = await MuMerchClientGet.Get<Size>($"size/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditSize(Size size)
        {
            size.UpdatedBy = Session["Id"].ToString();
            size.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("size/edit", size);
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
            return View(size);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteSize(int id)
        {
            var data = await MuMerchClientGet.Get<Size>($"size/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteSize(Size size)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("size/delete", size);
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
        public async Task<ActionResult> SizeList()
        {
            var data = await MuMerchClientGet.Get<List<Size>>("size/all");
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
            color.UpdatedBy = Session["Id"].ToString();
            color.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
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
            return View(color);
        }
        [HttpGet]
        public async Task<ActionResult> EditColor(int id)
        {
            var data = await MuMerchClientGet.Get<Color>($"color/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditColor(Color color)
        {
            color.UpdatedBy = Session["Id"].ToString();
            color.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("color/edit", color);
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
            return View(color);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteColor(int id)
        {
            var data = await MuMerchClientGet.Get<Color>($"color/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteColor(Color color)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("color/delete", color);
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
        public async Task<ActionResult> ColorList()
        {
            var data = await MuMerchClientGet.Get<List<Color>>("color/all");
            return View(data);
        }

        [HttpGet]
        public ActionResult AddUnit()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddUnit(Unit unit)
        {
            unit.UpdatedBy = Session["Id"].ToString();
            unit.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("unit/add", unit);
                    if (token > 0)
                    {

                        return RedirectToAction("UnitList");
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
            return View(unit);
        }
        [HttpGet]
        public async Task<ActionResult> EditUnit(int id)
        {
            var data = await MuMerchClientGet.Get<Unit>($"unit/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditUnit(Unit unit)
        {
            unit.UpdatedBy = Session["Id"].ToString();
            unit.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("unit/edit", unit);
                    if (token > 0)
                    {

                        return RedirectToAction("UnitList");
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
            return View(unit);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteUnit(int id)
        {
            var data = await MuMerchClientGet.Get<Unit>($"unit/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteUnit(Unit unit)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("unit/delete", unit);
                if (token > 0)
                {

                    return RedirectToAction("UnitList");
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
        public async Task<ActionResult> UnitList()
        {
            var data = await MuMerchClientGet.Get<List<Unit>>("unit/all");
            return View(data);
        }

        [HttpGet]
        public ActionResult AddGig()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddGig(Gig gig)
        {
            gig.UpdatedBy = Session["Id"].ToString();
            gig.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("gig/add", gig);
                    if (token > 0)
                    {

                        return RedirectToAction("GigList");
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
            return View(gig);
        }
        [HttpGet]
        public async Task<ActionResult> EditGig(int id)
        {
            var data = await MuMerchClientGet.Get<Gig>($"gig/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditGig(Gig gig)
        {
            gig.UpdatedBy = Session["Id"].ToString();
            gig.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("gig/edit", gig);
                    if (token > 0)
                    {

                        return RedirectToAction("GigList");
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
            return View(gig);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteGig(int id)
        {
            var data = await MuMerchClientGet.Get<Gig>($"gig/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteGig(Gig gig)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("gig/delete", gig);
                if (token > 0)
                {

                    return RedirectToAction("GigList");
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
        public async Task<ActionResult> GigList()
        {
            var data = await MuMerchClientGet.Get<List<Gig>>("gig/all");
            return View(data);
        }

        [HttpGet]
        public async Task<ActionResult> AddGigManager()
        {
            var gigmanager = await MuMerchClientGet.Get<List<GigManager>>("gigmanager/all");
            ViewBag.GigManager = gigmanager;
            var gig = await MuMerchClientGet.Get<List<Gig>>("gig/all");
            ViewBag.Gig = gig;
            var user = await MuMerchClientGet.Get<List<User>>("user/all");
            ViewBag.User = user;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddGigManager(GigManager gigmanager)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("gigmanager/add", gigmanager);
                    if (token > 0)
                    {

                        return RedirectToAction("GigManagerList");
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
            return View(gigmanager);
        }
        [HttpGet]
        public async Task<ActionResult> EditGigManager(int id)
        {
            var data = await MuMerchClientGet.Get<GigManager>($"gigmanager/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditGigManager(GigManager gigmanager)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("gigmanager/edit", gigmanager);
                    if (token > 0)
                    {

                        return RedirectToAction("GigManagerList");
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
            return View(gigmanager);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteGigManager(int id)
        {
            var data = await MuMerchClientGet.Get<GigManager>($"gigmanager/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteGigManager(GigManager gigmanager)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("gigmanager/delete", gigmanager);
                if (token > 0)
                {

                    return RedirectToAction("GigManagerList");
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
        public async Task<ActionResult> GigManagerList()
        {
            var data = await MuMerchClientGet.Get<List<GigManager>>("gigmanager/all");
            return View(data);
        }

        [HttpGet]
        public ActionResult AddBand()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddBand(Band band)
        {
            band.UpdatedBy = Session["Id"].ToString();
            band.UpdatedAt = DateTime.Now;
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
        public async Task<ActionResult> EditBand(int id)
        {
            var data = await MuMerchClientGet.Get<Band>($"band/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditBand(Band band)
        {
            band.UpdatedBy = Session["Id"].ToString();
            band.UpdatedAt = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("band/edit", band);
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
        public async Task<ActionResult> DeleteBand(int id)
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

        [HttpGet]
        public async Task<ActionResult> AddBandManager()
        {
            var bandmanager = await MuMerchClientGet.Get<List<BandManager>>("bandmanager/all");
            ViewBag.BandManager = bandmanager;
            var band = await MuMerchClientGet.Get<List<Band>>("band/all");
            ViewBag.Band = band;
            var user = await MuMerchClientGet.Get<List<User>>("user/all");
            ViewBag.User = user;

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddBandManager(BandManager bandmanager)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("bandmanager/add", bandmanager);
                    if (token > 0)
                    {

                        return RedirectToAction("BandManagerList");
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
            return View(bandmanager);
        }
        [HttpGet]
        public async Task<ActionResult> EditBandManager(int id)
        {
            var data = await MuMerchClientGet.Get<BandManager>($"bandmanager/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditBandManager(BandManager bandmanager)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("bandmanager/edit", bandmanager);
                    if (token > 0)
                    {

                        return RedirectToAction("BandManagerList");
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
            return View(bandmanager);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteBandManager(int id)
        {
            var data = await MuMerchClientGet.Get<BandManager>($"bandmanager/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteBandManager(BandManager bandmanager)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("bandmanager/delete", bandmanager);
                if (token > 0)
                {

                    return RedirectToAction("BandManagerList");
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
        public async Task<ActionResult> BandManagerList()
        {
            var data = await MuMerchClientGet.Get<List<BandManager>>("bandmanager/all");
            return View(data);
        }


        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("customer/add", customer);
                    if (token > 0)
                    {

                        return RedirectToAction("CustomerList");
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
            return View(customer);
        }
        [HttpGet]
        public async Task<ActionResult> EditCustomer(string id)
        {
            var data = await MuMerchClientGet.Get<Customer>($"customer/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> EditCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await MuMerchClientPost.Post<int>("customer/edit", customer);
                    if (token > 0)
                    {

                        return RedirectToAction("CustomerList");
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
            return View(customer);
        }
        [HttpGet]
        public async Task<ActionResult> DeleteCustomer(string id)
        {
            var data = await MuMerchClientGet.Get<Customer>($"customer/{id}");
            return View(data);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCustomer(Customer customer)
        {
            try
            {
                var token = await MuMerchClientPost.Post<int>("customer/delete", customer);
                if (token > 0)
                {

                    return RedirectToAction("CustomerList");
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

        public async Task<ActionResult> CustomerList()
        {
            var data = await MuMerchClientGet.Get<List<Customer>>("customer/all");
            return View(data);
        }
    }
}