using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MuMerchAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductSizeMapController : ApiController
    {
        [Route("api/productsizemap/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = ProductSizeMapService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/productsizemap/{id}")]
        public HttpResponseMessage GetSpec(int id)
        {
            try
            {
                var data = ProductSizeMapService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productsizemap/add")]
        public HttpResponseMessage Add(ProductSizeMapDTO productsizemapDTO)
        {
            try
            {
                var data = ProductSizeMapService.Add(productsizemapDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productsizemap/edit")]
        public HttpResponseMessage Edit(ProductSizeMapDTO productsizemapDTO)
        {
            try
            {
                var data = ProductSizeMapService.Edit(productsizemapDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productsizemap/delete")]
        public HttpResponseMessage Delete(ProductSizeMapDTO dto)
        {
            try
            {
                var data = ProductSizeMapService.Delete(dto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
